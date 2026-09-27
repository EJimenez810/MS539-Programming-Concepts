namespace FinancialBuddy.Core;

/// <summary>
/// Simulates monthly payments. Interest accrues monthly at APR / 12.
/// Assumes fixed rates, no fees, no new charges, and minimum payments
/// that remain constant until the final payment.
/// </summary>
public static class DebtCalculator
{
    private sealed class Balance
    {
        public required Debt Source { get; init; }
        public decimal Remaining { get; set; }
        public decimal InterestPaid { get; set; }
    }

    public static DebtPlan Simulate(
        IReadOnlyList<Debt> debts, decimal ExtraMonthlyPayment,
        PayoffMethod method, int maximumMonths = 1200)
    {
        ArgumentNullException.ThrowIfNull(debts);
        if (debts.Count == 0) throw new ArgumentException("Enter at least one debt.");
        if (ExtraMonthlyPayment < 0) throw new ArgumentOutOfRangeException(nameof(ExtraMonthlyPayment));
        if (maximumMonths < 1) throw new ArgumentOutOfRangeException(nameof(maximumMonths));
        if (debts.Any(d => string.IsNullOrWhiteSpace(d.Name) || d.Balance <= 0 ||
            d.AnnualPercentageRate is < 0 or > 100 || d.MinimumMonthlyPayment < 0))
            throw new ArgumentException("Each debt needs a name, positive balance, valid APR, and nonnegative minimum.");

        var balances = debts.Select(d => new Balance { Source = d, Remaining = d.Balance }).ToList();
        decimal budget = debts.Sum(d => d.MinimumMonthlyPayment) + ExtraMonthlyPayment;
        if (budget <= 0) throw new ArgumentException("Monthly payment budget must be positive.");

        decimal interestTotal = 0m;
        decimal paidTotal = 0m;
        var milestones = new List<DebtMilestone>();

        for (int month = 1; month <= maximumMonths; month++)
        {
            var active = balances.Where(b => b.Remaining > 0).ToList();
            if (active.Count == 0) return new DebtPlan(method, month - 1,
                interestTotal, paidTotal, milestones);

            foreach (var b in active)
            {
                decimal interest = decimal.Round(
                    b.Remaining * b.Source.AnnualPercentageRate / 1200m, 2,
                    MidpointRounding.AwayFromZero);
                b.Remaining += interest;
                b.InterestPaid += interest;
                interestTotal += interest;
            }

            decimal remainingBudget = budget;
            // Make minimum payments on every active debt before targeting extra cash.
            foreach (var b in active)
            {
                decimal payment = Math.Min(b.Remaining, b.Source.MinimumMonthlyPayment);
                payment = Math.Min(payment, remainingBudget);
                b.Remaining -= payment;
                remainingBudget -= payment;
                paidTotal += payment;
            }

            IEnumerable<Balance> ordered = method switch
            {
                PayoffMethod.Avalanche => active.OrderByDescending(b => b.Source.AnnualPercentageRate)
                    .ThenBy(b => b.Remaining),
                PayoffMethod.Snowball => active.OrderBy(b => b.Remaining)
                    .ThenByDescending(b => b.Source.AnnualPercentageRate),
                _ => throw new ArgumentOutOfRangeException(nameof(method))
            };

            foreach (var b in ordered)
            {
                if (remainingBudget <= 0) break;
                decimal payment = Math.Min(b.Remaining, remainingBudget);
                b.Remaining -= payment;
                remainingBudget -= payment;
                paidTotal += payment;
            }

            foreach (var b in active.Where(b => b.Remaining == 0))
                milestones.Add(new DebtMilestone(b.Source.Name, month, b.InterestPaid));

            if (balances.All(b => b.Remaining == 0))
                return new DebtPlan(method, month, interestTotal, paidTotal, milestones);
        }
        throw new InvalidOperationException(
            "The entered payment budget does not retire the debts within the simulation limit.");
    }
}
