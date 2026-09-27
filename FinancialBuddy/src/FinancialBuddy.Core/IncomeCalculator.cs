namespace FinancialBuddy.Core;

/// <summary>
/// Converts user-entered paycheck values into a consistent monthly/annual view.
/// Tax is an EXPLICIT USER ESTIMATE in this first milestone; no tax brackets or
/// jurisdiction-specific withholding are implied by these calculations.
/// </summary>
public static class IncomeCalculator
{
    public static IncomeResult Calculate(IncomeInput input)
    {
        if (input.GrossPerPaycheck < 0 || input.PretaxPerPaycheck < 0 ||
            input.PosttaxPerPaycheck < 0 || input.EstimatedTaxPerPaycheck < 0)
            throw new ArgumentOutOfRangeException(nameof(input), "Amounts cannot be negative.");

        var deductions = input.PretaxPerPaycheck + input.PosttaxPerPaycheck +
                         input.EstimatedTaxPerPaycheck;
        if (deductions > input.GrossPerPaycheck)
            throw new ArgumentException("Deductions and estimated tax exceed gross pay.");

        int periods = (int)input.Frequency;
        if (periods is not (1 or 12 or 24 or 26 or 52))
            throw new ArgumentException("Unsupported pay frequency.");

        decimal net = input.GrossPerPaycheck - deductions;
        decimal annual = net * periods;
        return new IncomeResult(
            input.GrossPerPaycheck * periods, annual, annual / 12m, net,
            input.PretaxPerPaycheck * periods, input.PosttaxPerPaycheck * periods,
            input.EstimatedTaxPerPaycheck * periods);
    }
}
