# Financial Buddy — personal MVP

This is a **new, separate calculation core** for the personal Financial Buddy MVP. The original MS539 WinForms coursework remains in its original folders.

## MVP workflows
1. Take-home pay using user-supplied estimated tax/withholding.
2. Debt snapshot and avalanche/snowball payoff simulations.
3. Retirement projection using explicit, adjustable assumptions.
4. Next: a mobile-first PWA connecting these workflows.

## Status
**Development only; not yet a working app.** Core models, calculators and starter unit tests have been committed. Compilation and tests are **not verified** in this environment.

The take-home-pay calculator currently uses a user-entered estimated tax amount. It does **not** compute federal/state/FICA taxes. The retirement model omits inflation, fees, taxes, Social Security and market volatility. Debt simulations assume fixed APRs, no fees and no new charges. Do not use these projections as financial advice.

## Run the tests
Install .NET 8 SDK and run:

```bash
dotnet test FinancialBuddy/tests/FinancialBuddy.Core.Tests/FinancialBuddy.Core.Tests.csproj
```

## Next steps
- Verify compilation and tests in an environment with .NET 8.
- Correct any baseline issues and expand test coverage.
- Build the mobile-first Blazor PWA, with local-only sample data.
- Add editable assumptions, scenario persistence and accessible results.
- Only then consider tax-table integrations and real personal financial inputs.

No client accounts, client records, insurance product comparisons, or team access are part of the MVP.
