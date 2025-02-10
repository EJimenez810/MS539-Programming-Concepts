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
    public partial class FTakeHomePay : Form
    {
        private string userName;


        public FTakeHomePay(string userName)
        {
            InitializeComponent();
            userName = userName;

            if (LabelTHP != null)
            {
                LabelTHP.Text = $"Welcome, {userName}, to Take Home Pay! Let's set you up for Success!";
            }
        }

        private void FTakeHomePay_Load(object sender, EventArgs e)
        {
            if (LabelTHP != null)
            {
                LabelTHP.Text = $"Welcome, {userName}, to Take Home Pay! Let's set you up for Success!";
                LabelTHP.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic);
                LabelTHP.ForeColor = Color.Green;
                LabelTHP.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                MessageBox.Show("LabelTHP is null. Please check the initialization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNGoHome_Click(object sender, EventArgs e)
        {
            FHomePage homePage = new FHomePage();
            homePage.Show();

            this.Close();
        }
    }
}

