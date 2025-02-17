using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._1___Random_Number_Guessing_Game
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int randomNumber;

        public Form1()
        {
            InitializeComponent();
            GenerateRandomNumber();
        }

        private void GenerateRandomNumber()
        {
            randomNumber = random.Next(1, 11);
        }

        private void BTNGuess_Click(object sender, EventArgs e)
        {
            int userGuess;

            if (int.TryParse(TBUserGuess.Text, out userGuess))
            {
                if (userGuess < 1 || userGuess > 10)
                {
                    LBLResults.Text = "Please enter a number between 1 and 10.";
                    LBLResults.ForeColor = Color.Red;
                    PBResult.Visible = false;
                    return;
                }

                string imagePath = Directory.GetCurrentDirectory() + @"\Images\";

                if (userGuess == randomNumber)
                {
                    LBLResults.Text = "Congratulations! Your guess is correct!";
                    LBLResults.ForeColor = Color.Green;
                    PBResult.ImageLocation = imagePath + "CorrectGuess.png";
                    PBResult.Visible = true;
                    GenerateRandomNumber();
                }
                
                else
                {
                    LBLResults.Text = $"Sorry, the correct number was " + randomNumber + ". Try Again!";
                    LBLResults.ForeColor = Color.Red;
                    PBResult.ImageLocation = imagePath + "WrongGuess.png";
                    PBResult.Visible = true;
                    GenerateRandomNumber();
                }
            }
            else
            {
                LBLResults.Text = "Please enter a valid number.";
                LBLResults.ForeColor = Color.Red;
                PBResult.Visible = false;
            }
        }
    }
}
