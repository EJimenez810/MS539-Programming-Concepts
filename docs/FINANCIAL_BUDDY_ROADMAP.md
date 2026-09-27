# Financial Buddy — Development Roadmap

Status: Planning / baseline verification. Original coursework remains unchanged on `main`.

## Product boundaries
- Personal edition: local-first income, take-home-pay estimates, budgets, debt, savings goals, scenario comparisons and accessible reports.
- Optional advisor edition: separate consent-based discovery and educational needs-analysis workflows for life insurance, annuity and health-insurance conversations. No automatic product recommendations or suitability determinations.
- Never collect Social Security numbers, bank credentials or health details in the MVP. No client data in GitHub or sample screenshots.
- Initial distribution: Windows desktop; revisit cross-platform or web after validating requirements.

## Authoritative source candidate
`Assignment 3.1 - Basic GUI and Exception Handling/Assignment 3.1 - Basic GUI and Exception Handling/Assignment 3.1 - Basic GUI and Exception Handling/`

This is the deepest nested copy and includes `TaxCalculators.cs`, updated `FHomePage` and the expanded `FTakeHomePay` form. Confirm it builds in Visual Studio before restructuring or deleting duplicates. Target framework: .NET Framework 4.7.2.

## Phase 0 — Baseline
- [ ] Open deepest nested solution in Visual Studio on Windows; restore/build Debug and Release.
- [ ] Run all forms and capture actual errors/screenshots.
- [ ] Verify designer event handlers, resources and home navigation.
- [ ] Record expected input basis (annual versus per-paycheck), tax year, and target Windows versions.
- [ ] After passing baseline, move a *copy* to a clean `FinancialBuddy/` directory and preserve coursework history.

## Phase 1 — Calculation correctness
- [ ] Move money and tax logic out of WinForms; use decimal and explicit units.
- [ ] Correct currently commented-out `ApplyPreTaxDeductions`.
- [ ] Distinguish gross pay, payroll-tax wages, federal/state taxable income and actual withholding.
- [ ] Replace 2023 federal brackets with sourced, tax-year-specific tables and support all displayed filing statuses.
- [ ] Replace incomplete/conflicting state classification and bracket data; unsupported cases must display warnings, not $0.
- [ ] Implement FICA, supported deduction treatment, sensible bounds and negative-result handling.
- [ ] Add unit tests for deductions, bracket boundaries, filing status, state coverage and pay periods.
- [ ] Display assumptions and an estimate disclaimer.

## Phase 2 — Usability
- [ ] Responsive WinForms layout using TableLayoutPanel, Dock/Anchor and AutoScroll.
- [ ] Keep Go Home and Calculate buttons visible at smaller window sizes.
- [ ] Validate paste, decimal separators, missing inputs and invalid negative values.
- [ ] Add clear labels, keyboard navigation, readable contrast and a printable breakdown.

## Phase 3 — Household features
- [ ] Monthly budget, recurring expenses, emergency-fund and savings goals.
- [ ] Debt snowball/avalanche projections with transparent assumptions.
- [ ] Optional encrypted local profiles, backup/export and no required online account.
- [ ] User acceptance testing with a small family/friends pilot.

## Phase 4 — Advisor edition (separate workflow)
- [ ] Opt-in client discovery with consent and minimal necessary data.
- [ ] Life insurance: educational needs scenarios, existing coverage and funding-gap worksheets.
- [ ] Annuities: retirement-income and liquidity scenarios; distinguish guaranteed versus illustrated outcomes.
- [ ] Health insurance: budget and coverage-comparison worksheets using approved/current plan materials.
- [ ] Separate licensed-agent review, suitability/compliance controls, disclosures, document retention and privacy assessment before real-client use.
- [ ] No quote generation, carrier integration, sensitive health data, or automated suitability decisions until separately designed and approved.

## Release gates
1. Baseline compiles and launches.
2. Calculator passes reference-case and boundary tests.
3. Accessibility and window-resize checks pass.
4. No sensitive data stored or committed.
5. Friends/family pilot confirms usability.
6. Advisor edition undergoes independent compliance and security review before real-client use.
