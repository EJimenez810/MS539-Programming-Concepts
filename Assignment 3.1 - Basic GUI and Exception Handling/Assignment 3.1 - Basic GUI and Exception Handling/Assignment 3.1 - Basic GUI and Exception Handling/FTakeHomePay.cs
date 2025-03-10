using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Assignment_3._1___Basic_GUI_and_Exception_Handling
{
    public partial class FTakeHomePay : Form
    {
        private string userName;
        private FHomePage homePageInstance;

        //Estimated time to complete this code:  2 to 4 hours
        //Actual time to complete this code: 5 hours
        //Estimated time to complete this code: 3 to 5 hours
        //Actual time to complete this code: 5 1/2 hours
        //Estimated time to complete this code: 4 to 6 hours
        //Actual time to complete this code: 8 hours
        //Estimated time to complete this code: 2 hours
        //Actual time to complete this code: 3 hours


        //The following code is to set up a Financial Calculator Parent Class and Encapsulates Gross Income & Taxable Income
        public class FinanceCalculator
        {
            protected double grossIncome;
            protected double taxableIncome;

            public FinanceCalculator(double grossIncome)
            {
                this.grossIncome = grossIncome;
                this.taxableIncome = grossIncome;
            }

            //The following Method is to calculate the taxable income after pre-tax deductions
            public void ApplyPreTaxDeductions(double preTaxDeductions)
            {
                taxableIncome -= preTaxDeductions;
            }

            //The following is the Getter for taxable income
            public double GetTaxableIncome()
            {
                return taxableIncome;
            }
        }
            //The following code defines the List for the Pre-Tax and Post-Tax Deduction Names

            private List<string> preTaxDeductions = new List<string> { "401K", "Medical", "Dental", "Vision", "HSAFSA", "Commuter" };
            private List<string> postTaxDeductions = new List<string> { "ADnD", "CritILL", "ACCIns", "HosInd","SpsLife", "DepLife", "LTD", "Legal", "PSL" };
            private string payPeriod;

        public FTakeHomePay(FHomePage homePage)
        {
            InitializeComponent();

            //The following code assigns the existing instance of the homePage form to the homePageInstance variable

            this.homePageInstance = homePage ?? throw new ArgumentNullException(nameof(homePage));

            //The following code sets the userName to the value passed in from the previous form for the welcome message/banner at the top of the form

            this.userName = homePageInstance.UserName ?? "Guest";

            //The following code applies numeric validation to the Gross Pay textbox
            TBGrossIncome.KeyPress += TBGrossPay_KeyPress;

            //The following code applies numeric validation to all deduction textboxes
            ApplyNumericValidation();

            //The following code ensures that the pre-tax & post-tax totals are updated in real-time
            ApplyRealTimePreTaxCalculation();
            ApplyRealTimePostTaxCalculation();

            //the if statement checks if the label is not null, then sets the text of the label to the welcome message/banner. meant to be display the users name and add a touch of personalization

            if (LabelTHP != null)
            {
                //Added ToUpper() to make the name all uppercase

                LabelTHP.Text = $"Welcome, {this.userName.ToUpper()}, to Take Home Pay Calculator!";
            }
            
            else
            {
                MessageBox.Show("Please submit your name on the home screen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FTakeHomePay_Load(object sender, EventArgs e)
        {
            //The following code sets the welcome message/banner to the top of the form. It also sets the font, color, and alignment of the text.
            
            if (LabelTHP != null)
            {
                LabelTHP.Text = $"Welcome, {userName}, to Take Home Pay! Let's set you up for Success!";
                LabelTHP.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic);
                LabelTHP.ForeColor = Color.Green;
                LabelTHP.TextAlign = ContentAlignment.MiddleCenter;
            }
            
            else
            {
                MessageBox.Show("Please submit your name on the home screen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // The following code ensures the combo boxes are clear before adding items

            CBStateIncTax.Items.Clear();
            CBFilingStat.Items.Clear();
            CBPayPeriod.Items.Clear();

            // The following code populates the CBStateIncTax with U.S. States

            CBStateIncTax.Items.AddRange(new string[]
            {
               "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware",
               "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky",
               "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi",
               "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico",
               "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania",
               "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont",
               "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming", "District of Columbia"
            });

            // The following code sets default selection
            
            CBStateIncTax.SelectedIndex = 0;

            // The following code populates CBFilingStat with filing statuses
            
            CBFilingStat.Items.AddRange(new string[] 
            { 
                "Single", "Married", "Head of Household" 
            });

            // The following sets default selection

            CBFilingStat.SelectedIndex = 0;

            // The following code populates CBPayPeriod with pay periods

            CBPayPeriod.Items.AddRange(new string[]
            {
                "Weekly", "Bi-Weekly", "Monthly", "Semi-Monthly", "Annually"
            });

            // The following code sets default selection

            CBPayPeriod.SelectedIndex = 0;
        }

        private void BTNCalcNetInc_Click(object sender, EventArgs e)
        {
            try
            {
                // The following code is to validate user inputs

                if (string.IsNullOrWhiteSpace(TBGrossIncome.Text) ||
                    CBStateIncTax.SelectedItem == null ||
                    CBFilingStat.SelectedItem == null ||
                    CBPayPeriod.SelectedItem == null)
                {
                    // The following code highlights the Gross Income field in red

                    TBGrossIncome.BackColor = Color.LightCoral; 
                    MessageBox.Show("Please enter Gross Income, select State, Filing Status, and Pay Period.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // The following code reads the inputs from the user

                double grossIncome = double.Parse(TBGrossIncome.Text);
                string selectedState = CBStateIncTax.SelectedItem.ToString();
                string filingStatus = CBFilingStat.SelectedItem.ToString();
                string payPeriod = CBPayPeriod.SelectedItem.ToString(); 

                // The following code applies Pre-Tax Deductions

                double preTaxDeductions = GetPreTaxDeductions();
                FinanceCalculator financeCalculator = new FinanceCalculator(grossIncome);
                
                //financeCalculator.ApplyPreTaxDeductions(preTaxDeductions);
                
                double taxableIncome = financeCalculator.GetTaxableIncome();

                // The following code calculates Federal and State Taxes

                FederalTaxCalculator federalTaxCalculator = new FederalTaxCalculator(taxableIncome, filingStatus);
                double federalTax = federalTaxCalculator.CalculateFederalIncomeTax();

                StateTaxCalculator stateTaxCalculator = new StateTaxCalculator(taxableIncome, selectedState, filingStatus);
                double stateTax = stateTaxCalculator.CalculateStateIncomeTax();

                // The following code calculates Net Income or Final Take Home Pay

                double takeHomePay = taxableIncome - federalTax - stateTax - GetPostTaxDeductions();

                // The following adjusts the take-home pay based on pay period

                double adjustedTakeHomePay = takeHomePay; // The default is annual
                  switch (payPeriod)
                  {
                            case "Weekly":
                                adjustedTakeHomePay /= 52;
                                break;

                            case "Bi-Weekly":
                                adjustedTakeHomePay /= 26;
                                break;

                            case "Monthly":
                                adjustedTakeHomePay /= 12;
                                break;

                            case "Semi-Monthly":
                                adjustedTakeHomePay /= 24;
                                break;
                  }


                // The following code displays the results (updated to use a single label for all results)

                //LBLTakeHomePay.Text =
                //    $"📌 **Net Income Breakdown:**\n" +
                //    $"🟢 **Gross Income:** ${grossIncome:F2}\n" +
                //    $"🔻 **Federal Tax:** ${federalTax:F2}\n" +
                //    $"🔻 **State Tax:** ${stateTax:F2}\n" +
                //    $"🟠 **Pre-Tax Deductions:** ${preTaxDeductions:F2}\n" +
                //    $"🔵 **Post-Tax Deductions:** ${GetPostTaxDeductions():F2}\n" +
                //    $"✅ **Take-Home Pay ({payPeriod}):** ${adjustedTakeHomePay:F2}";

                // Decided that since I already have the lables set up, I will just update them individually as I liked that functionality better.

                    LBLFedTax.Text = $"Federal Tax: ${federalTax:F2}";
                    LBLStateTax.Text = $"State Tax: ${stateTax:F2}";
                    LBLTakeHomePay.Text = $"Take Home Pay ({payPeriod}): ${adjustedTakeHomePay:F2}";
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Error calculating taxes: " + ex.Message, "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // The following method calculates the pre-tax deductions

        private double GetPreTaxDeductions()
        {
            double preTaxDeductions = 0;
            foreach (Control ctrl in GBPreTaxDed.Controls)
            {
                if (ctrl is TextBox textBox && !string.IsNullOrEmpty(textBox.Text))
                {
                    if (double.TryParse(textBox.Text, out double value))
                    {
                        preTaxDeductions += value;
                    }
                }
            }
            return preTaxDeductions;
        }

        //The following method calculates the post-tax deductions

        private double GetPostTaxDeductions()
        {
            double postTaxDeductions = 0;
            foreach (Control ctrl in GBPostTaxDed.Controls)
            {
                if (ctrl is TextBox textBox && !string.IsNullOrEmpty(textBox.Text))
                {
                    if (double.TryParse(textBox.Text, out double value))
                    {
                        postTaxDeductions += value;
                    }
                }
            }
            return postTaxDeductions;
        }

        //The following code applises numeric-only validation to Gross Pay Textbox

        private void TBGrossPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        //The following code applies numeric-only validation to all deduction textboxes

        private void ApplyNumericValidation()
        {

            foreach (Control ctrl in GBPreTaxDed.Controls)
            {

                if (ctrl is TextBox textBox)
                {

                    textBox.KeyPress += TextBox_KeyPress;
                }

            }

            //The below code is the same as the above code, but for the post-tax deduction textboxes

            foreach (Control ctrl in GBPostTaxDed.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.KeyPress += TextBox_KeyPress;
                }
            }
        }

        //the following code is to prevent non-numeric input in the textboxes

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //The following code prevents multiple decimal points in the textboxes

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        //the following code applies real-time update for total pre-tax deductions

        private void UpdatePreTaxTotal()
        {
            double preTaxTotal = 0;

            foreach (Control ctrl in GBPreTaxDed.Controls)
            {

                if (ctrl is TextBox textBox && !string.IsNullOrEmpty(textBox.Text))
                {
                    //Updated the code to remove the hard-coded deduction names and use the list of pre-tax deductions

                    string deductionName = textBox.Name.Replace("TB", "");
                    if (preTaxDeductions.Contains(deductionName))
                    { 
                        if (double.TryParse(textBox.Text, out double value))
                        {
                            preTaxTotal += value;
                        }
                        
                    }
            
                }
            }

            //The following code is to display the updated total in the label LBLTotalPreTax
            
            LBLTotalPreTax.Text = $"Total Pre-Tax Deductions: ${preTaxTotal:F2}";
        }

        //The following code attaches real-time update event to all pre-tax deduction textboxes

        private void ApplyRealTimePreTaxCalculation()
        {
            foreach (Control ctrl in GBPreTaxDed.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.TextChanged += (s, e) => UpdatePreTaxTotal();
                }
            }
        }

        //The following code applies real-time update for total post-tax deductions

        private void UpdatePostTaxTotal()
        {
            double postTaxTotal = 0;

            foreach (Control ctrl in GBPostTaxDed.Controls)
            {

                //Updated the code to remove the hard-coded deduction names and use the list of post-tax deductions

                if (ctrl is TextBox textBox && !string.IsNullOrEmpty(textBox.Text))
                {
                    string deductionName = textBox.Name.Replace("TB", "");
                    if (postTaxDeductions.Contains(deductionName))
                    {
                        if (double.TryParse(textBox.Text, out double value))
                        {
                            postTaxTotal += value;
                        }

                    }

                }
            }

            //The following code is to display the updated total in the label LBLTotalPostTax

            LBLTotalPostTax.Text = $"Total Post-Tax Deductions: ${postTaxTotal:F2}";

        }

        // The following code attaches real-time update event to all post-tax deduction textboxes

        private void ApplyRealTimePostTaxCalculation()
        {
            foreach (Control ctrl in GBPostTaxDed.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.TextChanged += (s, e) => UpdatePostTaxTotal();
                }
            }
        }



        //The following code confirms returning to the home page and hides the current form

        private void BTNGoHome_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to return to the Home Page?", "Confirm Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Hide();
                homePageInstance.Show();

            }
        }

        //private void FTakeHomePay_Resize(object sender, EventArgs e)
        //{
        //    // The following code adjusts the width of LBLTakeHomePay to fit the form
        //    LBLTakeHomePay.Width = this.ClientSize.Width - 40;
        //    LBLTakeHomePay.Location = new Point(20, this.ClientSize.Height - 150);

        //    // The following code moves buttons to always remain at the bottom of the form
        //    BTNCalcNetInc.Location = new Point(this.ClientSize.Width - BTNCalcNetInc.Width - 20, this.ClientSize.Height - BTNCalcNetInc.Height - 20);
        //    BTNGoHome.Location = new Point(20, this.ClientSize.Height - BTNGoHome.Height - 20);
        //}

        // The following code changes the color of the buttons when the mouse hovers over them

        private void BTNCalcNetInc_MouseEnter(object sender, EventArgs e)
        {
            BTNCalcNetInc.BackColor = Color.DarkGreen;
        }

        private void BTNCalcNetInc_MouseLeave(object sender, EventArgs e)
        {
            BTNCalcNetInc.BackColor = Color.ForestGreen;
        }

        private void BTNGoHome_MouseEnter(object sender, EventArgs e)
        {
            BTNGoHome.BackColor = Color.DarkRed;
        }

        private void BTNGoHome_MouseLeave(object sender, EventArgs e)
        {
            BTNGoHome.BackColor = Color.Red;
        }
    }
}

