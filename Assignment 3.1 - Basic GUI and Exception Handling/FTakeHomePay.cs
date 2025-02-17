using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public FTakeHomePay(FHomePage homePage, string userName)
        {
            InitializeComponent();

            //The following code assigns the existing instance of the homePage form to the homePageInstance variable

            this.homePageInstance = homePage;

            //The following code sets the userName to the value passed in from the previous form for the welcome message/banner at the top of the form

            userName = userName;

            //The following code applies numeric validation to all deduction textboxes
            ApplyNumericValidation();

            //The following code ensures that the pre-tax & post-tax totals are updated in real-time
            ApplyRealTimePreTaxCalculation();
            //ApplyRealTimePostTaxCalculation();

            //the if statement checks if the label is not null, then sets the text of the label to the welcome message/banner. meant to be display the users name and add a touch of personalization

            if (LabelTHP != null)
            {
                LabelTHP.Text = $"Welcome, {userName}, to Take Home Pay! Let's set you up for Success!";
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
                    if (double.TryParse(textBox.Text, out double value))
                    {
                        preTaxTotal += value;
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

        private void BTNGoHome_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to return to the Home Page?", "Confirm Navigation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Hide();
                homePageInstance.Show();

            }
        }
    }
}

