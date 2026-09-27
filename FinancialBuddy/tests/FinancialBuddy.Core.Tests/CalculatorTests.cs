using FinancialBuddy.Core;
using Xunit;

namespace FinancialBuddy.Core.Tests;

public sealed class CalculatorTests
{
    [Fact]
    public void Income_ConvertsBiweeklyPayToAnnualAndMonthly()
    {
        var result = IncomeCalculator.Calculate(
            new IncomeInput(2000m, PayFrequency.Biweekly, 100m, 50m, 300m));
        Assert.Equal(40300m, result.NetAnnual);
        Assert.Equal(3358.3333333333333333333333333m, result.NetMonthly);
        Assert.Equal(1550m, result.NetPerPaycheck);
    }

    [Fact]
    public void Income_RejectsDeductionsAboveGross()
    {
        Assert.Throws<ArgumentException>(() => IncomeCalculator.Calculate(
            new IncomeInput(100m, PayFrequency.Monthly, 101m)));
    }

    [Fact]
    public void Debt_ZeroInterestSingleDebtHasPredictablePayoff()
    {
        var plan = DebtCalculator.Simulate(
            [new Debt("Card", 1200m, 0m, 100m)], 0m, PayoffMethod.Avalanche);
        Assert.Equal(12, plan.MonthsToPayoff);
        Assert.Equal(0m, plan.TotalInterest);
        Assert.Equal(1200m, plan.TotalPaid);
    }

    [Fact]
    public void Debt_ExtraPaymentAcceleratesPayoff()
    {
        var debts = new[] { new Debt("Card", 1200m, 0m, 100m) };
        var plan = DebtCalculator.Simulate(debts, 100m, PayoffMethod.Snowball);
        Assert.Equal(6, plan.MonthsToPayoff);
    }

    [Fact]
    public void Retirement_ZeroReturnAddsContributions()
    {
        var result = RetirementCalculator.Project(
            new RetirementInput(60, 61, 1000m, 100m, 0m, 0m));
        Assert.Equal(2200m, result.ProjectedSavings);
        Assert.Equal(7.33m, result.IllustrativeMonthlyIncome);
    }
}
