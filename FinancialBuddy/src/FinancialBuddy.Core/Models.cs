namespace FinancialBuddy.Core;

public enum PayFrequency { Weekly = 52, Biweekly = 26, Semimonthly = 24, Monthly = 12, Annual = 1 }
public enum PayoffMethod { Avalanche, Snowball }

public sealed record IncomeInput(
    decimal GrossPerPaycheck,
    PayFrequency Frequency,
    decimal PretaxPerPaycheck = 0m,
    decimal PosttaxPerPaycheck = 0m,
    decimal EstimatedTaxPerPaycheck = 0m);

public sealed record IncomeResult(
    decimal GrossAnnual, decimal NetAnnual, decimal NetMonthly,
    decimal NetPerPaycheck, decimal PretaxAnnual, decimal PosttaxAnnual,
    decimal EstimatedTaxAnnual);

public sealed record Debt(string Name, decimal Balance, decimal AnnualPercentageRate, decimal MinimumMonthlyPayment);
public sealed record DebtMilestone(string DebtName, int PaidOffMonth, decimal InterestPaid);
public sealed record DebtPlan(
    PayoffMethod Method, int MonthsToPayoff, decimal TotalInterest,
    decimal TotalPaid, IReadOnlyList<DebtMilestone> Milestones);

public sealed record RetirementInput(
    int CurrentAge, int RetirementAge, decimal CurrentSavings,
    decimal MonthlyContribution, decimal AssumedAnnualReturnPercent,
    decimal MonthlyIncomeGoal, decimal AssumedAnnualWithdrawalPercent = 4m);

public sealed record RetirementResult(
    decimal ProjectedSavings, decimal IllustrativeMonthlyIncome,
    decimal MonthlyIncomeGap, decimal AdditionalMonthlyContributionNeeded);
