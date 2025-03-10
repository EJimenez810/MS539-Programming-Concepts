using System;
using System.Collections.Generic;
using static Assignment_3._1___Basic_GUI_and_Exception_Handling.FTakeHomePay;

namespace Assignment_3._1___Basic_GUI_and_Exception_Handling
{
    // The following class calculates the state income tax based on the state and filing status
    
    public class StateTaxCalculator : FinanceCalculator
    {
        // The following stores the user selected state
        
        private string state;

        // The following stores the user's filing status (Single, Married, etc.)
        
        private string filingStatus;

        // The following defines the sets of states based on their tax structures
       
        private static readonly HashSet<string> no_income_tax_states = new HashSet<string>
        {
            "Alaska", "Florida", "Nevada", "New Hampshire", "South Dakota", "Tennessee", "Texas", "Washington", "Wyoming"
        };

        private static readonly HashSet<string> flat_tax_states = new HashSet<string>
        {
            "Arizona", "Colorado", "Georgia", "Idaho", "Illinois", "Indiana", "Kentucky", "Michigan",
            "North Carolina", "Pennsylvania", "Utah"
        };

        private static readonly HashSet<string> graduated_tax_states = new HashSet<string>
        {
            "Alabama", "Arkansas", "California", "Connecticut", "Delaware", "Hawaii", "Idaho", "Iowa", "Kansas",
            "Louisiana", "Maine", "Maryland", "Massachusetts", "Minnesota", "Mississippi", "Missouri", "Montana",
            "Nebraska", "New Jersey", "New Mexico", "New York", "North Dakota", "Ohio", "Oklahoma", "Oregon",
            "Rhode Island", "South Carolina", "Vermont", "Virginia", "West Virginia", "Wisconsin", "District of Columbia"
        };

        private static readonly Dictionary<string, List<Tuple<double, double>>> stateTaxBrackets = new Dictionary<string, List<Tuple<double, double>>>
        {
            { "Alabama", new List<Tuple<double, double>>
                { new Tuple<double, double>(500, 0.02),
                  new Tuple<double, double>(3000, 0.04),
                  new Tuple<double, double>(9999999, 0.05)
                }
            },

            { "Arkansas", new List<Tuple<double, double>>
                { new Tuple<double, double>(4000, 0.02),
                  new Tuple<double, double>(8000, 0.04),
                  new Tuple<double, double>(9999999, 0.059)
                }
            },

            { "California", new List<Tuple<double, double>>
               { new Tuple<double, double>(9325, 0.01),
                 new Tuple<double, double>(22107, 0.02),
                 new Tuple<double, double>(34892, 0.04),
                 new Tuple<double, double>(48435, 0.06),
                 new Tuple<double, double>(61214, 0.08),
                 new Tuple<double, double>(312686, 0.093)
                }
            },

            { "New York", new List<Tuple<double, double>>
                { new Tuple<double, double>(8500, 0.04),
                  new Tuple<double, double>(11700, 0.045),
                  new Tuple<double, double>(13900, 0.0525),
                  new Tuple<double, double>(21400, 0.059),
                  new Tuple<double, double>(80650, 0.0633),
                  new Tuple<double, double>(215400, 0.0685),
                  new Tuple<double, double>(1077550, 0.0882)
                }
            },

            { "District of Columbia", new List<Tuple<double, double>>
                { new Tuple<double, double>(0, 0.04),
                  new Tuple<double, double>(10000, 0.06),
                  new Tuple<double, double>(40000, 0.065),
                  new Tuple<double, double>(60000, 0.085),
                  new Tuple<double, double>(250000, 0.0925),
                  new Tuple<double, double>(500000, 0.0975),
                  new Tuple<double, double>(1000000, 0.1075)
                }
            },

            { "Virginia", new List<Tuple<double, double>>
                { new Tuple<double, double>(0, 0.02),
                  new Tuple<double, double>(3000, 0.03),
                  new Tuple<double, double>(5000, 0.05),
                  new Tuple<double, double>(17000, 0.0575)
                }
            },

        };

        // The following constructor initializes the state tax calculator with user inputs

        public StateTaxCalculator(double grossIncome, string state, string filingStatus) : base(grossIncome)
        {
            this.state = state;
            this.filingStatus = filingStatus;
        }

        // The following method determines which type of tax system the state follows and calculates tax accordingly
        
        public double CalculateStateIncomeTax()
        {
            Console.WriteLine($"Calculating State Tax for {state}, Filing Status: {filingStatus}");

            // The following states if the state has no income tax, return 0

            if (no_income_tax_states.Contains(state))
            {
                return 0;
            }

            // The following applies flat tax rate
            
            if (flat_tax_states.Contains(state))
            {
                return taxableIncome * GetFlatTaxRate(state);
            }

            // The following applies graduated tax rate
            
            if (graduated_tax_states.Contains(state))
            {
                return ApplyGraduatedTaxRate(state, taxableIncome);
            }

            // The following is the default return value if no category is matched

            Console.WriteLine($"State not found: {state}");
            return 0;
        }

        // The following returns the flat tax rate for states with a flat tax system
        
        private double GetFlatTaxRate(string state)
        {
            Dictionary<string, double> flatTaxRates = new Dictionary<string, double>()
            {
                { "Arizona", 0.025 }, 
                { "Colorado", 0.044 }, 
                { "Georgia", 0.0539 },
                { "Illinois", 0.0495 }, 
                { "Indiana", 0.03 }, 
                { "Iowa", 0.038 },
                { "Kentucky", 0.04 }, 
                { "Louisiana", 0.03 }, 
                { "Michigan", 0.0425 },
                { "Mississippi", 0.044 }, 
                { "North Carolina", 0.0425 },
                { "Pennsylvania", 0.0307 }, 
                { "Utah", 0.0485 }
            };

            // The following returns tax rate if state exists in dictionary
            
            return flatTaxRates.ContainsKey(state) ? flatTaxRates[state] : 0;
        }

        // The following calculates state tax based on graduated tax brackets

        private double ApplyGraduatedTaxRate(string state, double taxableIncome)
        {
            //Dictionary<string, List<Tuple<double, double>>> stateTaxBrackets = new Dictionary<string, List<Tuple<double, double>>>()
            //{
            //    { "California", new List<Tuple<double, double>>()
            //        {
            //            new Tuple<double, double>(9325, 0.01),   // 1% up to $9,325
            //            new Tuple<double, double>(22107, 0.02),  // 2% up to $22,107
            //            new Tuple<double, double>(34892, 0.04),  // 4% up to $34,892
            //            new Tuple<double, double>(48435, 0.06),  // 6% up to $48,435
            //            new Tuple<double, double>(61214, 0.08),  // 8% up to $61,214
            //            new Tuple<double, double>(312686, 0.093) // 9.3% above $312,686
            //        }
            //    }
            //};

            // The following states if no bracket data exists for the state, return 0

            if (!stateTaxBrackets.ContainsKey(state))
            {
                return 0;
            }

            double stateTax = 0;
            double previousBracket = 0;

            // The following loops through the tax brackets

            foreach (var bracket in stateTaxBrackets[state])
            {
                if (taxableIncome > previousBracket)
                {
                    double taxableAmount = Math.Min(taxableIncome,bracket.Item1) - previousBracket;
                    stateTax += taxableAmount * bracket.Item2;
                }
                previousBracket = bracket.Item1;
            }

            return stateTax;
        }
    }

    // The following class calculates the federal income tax based on federal tax brackets

    public class FederalTaxCalculator : FinanceCalculator
    {
        // The following stores the user's filing status
        
        private string filingStatus;

        // The following constructor initializes the federal tax calculator with user inputs
        
        public FederalTaxCalculator(double grossIncome, string filingStatus) : base(grossIncome)
        {
            this.filingStatus = filingStatus;
        }

        // The following calculates federal income tax based on the user's taxable income
        
        public double CalculateFederalIncomeTax()
        {
            Dictionary<string, List<Tuple<double, double>>> federalTaxBrackets = new Dictionary<string, List<Tuple<double, double>>>()
            {
                { "Single", new List<Tuple<double, double>>()
                    {
                        new Tuple<double, double>(11000, 0.10),
                        new Tuple<double, double>(44725, 0.12),
                        new Tuple<double, double>(95375, 0.22),
                        new Tuple<double, double>(182100, 0.24),
                        new Tuple<double, double>(231250, 0.32),
                        new Tuple<double, double>(578125, 0.35),
                        new Tuple<double, double>(9999999, 0.37)
                    }
                }
            };

            // The following is the default to Single if not found

            if (!federalTaxBrackets.ContainsKey(filingStatus))
            {
                filingStatus = "Single";
            }

            double federalTax = 0;

            // The following loops through the tax brackets
            
            double previousBracket = 0;

            foreach (var bracket in federalTaxBrackets[filingStatus])
            {
                if (taxableIncome > previousBracket)
                {
                    double taxableAmount = Math.Min(taxableIncome, bracket.Item1) - previousBracket;
                    federalTax += taxableAmount * bracket.Item2;
                }

                previousBracket = bracket.Item1;
            }

            return federalTax;
        }
    }
}
