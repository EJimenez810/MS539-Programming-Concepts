using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3._1___Basic_GUI_and_Exception_Handling
{
    public partial class FDebtStrategy : Form
    {
        private string userName;
        private FHomePage homePageInstance;

        public FDebtStrategy(FHomePage homePage)
        {
            InitializeComponent();

            this.homePageInstance = homePage ?? throw new ArgumentNullException(nameof(homePage));
            this.userName = homePageInstance.UserName ?? "Guest";

            if (LabelDSW != null)
            {
                LabelDSW.Text = $"Welcome, {this.userName.ToUpper()}, to Debt Strategy Calculator!";
            }
        }

        private void FDebtStrategy_Load(object sender, EventArgs e)
        {
            if (LabelDSW != null)
            {
                LabelDSW.Text = $"Welcome, {userName}, to Debt Strategy! Let's set you up for Success!";
                LabelDSW.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic);
                LabelDSW.ForeColor = Color.Red;
                LabelDSW.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                MessageBox.Show("LabelDSW is null. Please check the initialization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
