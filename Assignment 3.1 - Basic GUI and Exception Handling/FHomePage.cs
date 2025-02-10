using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3._1___Basic_GUI_and_Exception_Handling
{
    public partial class FHomePage : Form
    {
        private static string userName = "";

        // Estimated time to complete this code:  1 hour to 2 hours
        // Actual time to complete this code: 4 hours


        public FHomePage()
        {
            InitializeComponent();
        }

        private void FHomePage_Load(object sender, EventArgs e)
        {

        }

        private void TBGo2URL_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNGo2URL_Click(object sender, EventArgs e)
        {
            try
            {
                Uri uriResult; // Creates a URI object from the URL
                bool isValidUrl = Uri.TryCreate(TBGo2URL.Text, UriKind.Absolute, out uriResult)
                         && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

                if (isValidUrl)
                {
                    // Create ProcessStartInfo to open the URL in the default browser
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = uriResult.ToString(),
                        UseShellExecute = true // Necessary for opening URLs
                    };

                    Process.Start(psi);
                }
                else
                {
                    MessageBox.Show("Invalid URL. Please enter a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNNameSubmit_Click(object sender, EventArgs e)
        {
            string inputName = TBName.Text.Trim();
            if (string.IsNullOrEmpty(inputName) || Regex.IsMatch(inputName, "\\d"))
            {
                MessageBox.Show("Please enter a valid name. No Numbers Allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            userName = inputName;
            MessageBox.Show($"Thank you {userName}, Welcome to Financial Buddy!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LabelWelcomeBannerHome.Text = $"Welcome {userName} to Financial Buddy!"; // Update the label with the user's name
        }

        private void BTNBudgetStrat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter your name before continuing.", "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FBudgetStrategy budgetStrategyForm = new FBudgetStrategy(userName);
            budgetStrategyForm.Show();
        }

        private void BTNTakeHomeP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter your name before continuing.", "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FTakeHomePay takeHomePayForm = new FTakeHomePay(userName);
            takeHomePayForm.Show();
        }

        private void BTNDebtStrategy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter your name before continuing.", "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FDebtStrategy debtStrategyForm = new FDebtStrategy(userName);
            debtStrategyForm.Show();
        }
    }
}

