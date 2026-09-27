namespace FinancialBuddy.Core;

/// <summary>
/// Illustrative compound-growth projection, not a guaranteed investment outcome.
/// Monthly contributions are assumed to occur at the end of each month.
/// No taxes, fees, inflation, or market volatility are modeled in this MVP engine.
/// </summary>
public static class RetirementCalculator
{
    public static RetirementResult Project(RetirementInput input)
    {
        if (input.CurrentAge is < 0 or > 100 || input.RetirementAge <= input.CurrentAge ||
            input.RetirementAge > 110 || input.CurrentSavings < 0 ||
            input.MonthlyContribution < 0 || input.MonthlyIncomeGoal < 0 ||
            input.AssumedAnnualReturnPercent is < -100 or > 100 ||
            input.AssumedAnnualWithdrawalPercent is <= 0 or > 100)
            throw new ArgumentException("Check the retirement ages, amounts, and assumptions.");

        int months = (input.RetirementAge - input.CurrentAge) * 12;
        decimal monthlyRate = input.AssumedAnnualReturnPercent / 1200m;
        decimal projected = Grow(input.CurrentSavings, input.MonthlyContribution, monthlyRate, months);
        decimal monthlyIncome = projected * input.AssumedAnnualWithdrawalPercent / 1200m;
        decimal targetSavings = input.MonthlyIncomeGoal * 1200m / input.AssumedAnnualWithdrawalPercent;
        decimal targetGap = Math.Max(0m, targetSavings - projected);
        decimal factor = Grow(0m, 1m, monthlyRate, months);
        decimal additionalContribution = factor > 0 ? targetGap / factor : 0m;

        return new RetirementResult(
            decimal.Round(projected, 2), decimal.Round(monthlyIncome, 2),
            decimal.Round(Math.Max(0m, input.MonthlyIncomeGoal - monthlyIncome), 2),
            decimal.Round(additionalContribution, 2));
    }

    private static decimal Grow(decimal principal, decimal monthlyPayment,
        decimal monthlyRate, int months)
    {
        decimal balance = principal;
        for (int i = 0; i < months; i++)
        {
            balance += balance * monthlyRate;
            balance += monthlyPayment;
        }
        return balance;
    }
}
