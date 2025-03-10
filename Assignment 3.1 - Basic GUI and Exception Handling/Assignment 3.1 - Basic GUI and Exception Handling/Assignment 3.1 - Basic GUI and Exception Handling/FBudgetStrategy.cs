using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3._1___Basic_GUI_and_Exception_Handling
{
    public partial class FBudgetStrategy : Form
    {
        private string userName;
        private FHomePage homePageInstance;

        public FBudgetStrategy(FHomePage homePage)
        {
            InitializeComponent();

            this.homePageInstance = homePage ?? throw new ArgumentNullException(nameof(homePage));

            this.userName = homePageInstance.UserName ?? "Guest";


            if (LabelBSW != null)
            {
                LabelBSW.Text = $"Welcome, {this.userName.ToUpper()}, to Budget Strategy Calcu!";
            }

            else
            {
                MessageBox.Show("Please submit your name on the home screen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FBudgetStrategy_Load(object sender, EventArgs e)
        {
            if (LabelBSW != null)
            {
                LabelBSW.Text = $"Welcome, {userName}, to Budget Strategy! Let's set you up for Success!";
                LabelBSW.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic);
                LabelBSW.ForeColor = Color.MediumSlateBlue;
                LabelBSW.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                MessageBox.Show("Please submit your name on the home screen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LabelBSW_Click(object sender, EventArgs e)
        {

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

        private void FBudgetStrategy_Load_1(object sender, EventArgs e)
        {

        }
    }
}
