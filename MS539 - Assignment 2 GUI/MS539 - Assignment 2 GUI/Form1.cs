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

namespace MS539___Assignment_2_GUI
{
    public partial class Form1 : Form
    {
        // Variables for this form go here
        int num1, Cute;
        public Form1()
        {
            InitializeComponent();
        }

        private void TBNameInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CBHappy_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You are happy! That is Great!");
        }

        private void CBSad_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You are sad! That is not good!");
        }

        private void CBMad_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Oh No! You are mad! That is Horrible!");
        }

        private void CBBored_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Oh, You are bored? Try Reading a Book or Playing a Game?");
        }

        private void BTNSubmitName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + TBNameInput.Text + " Thank You for Inputing Your Name!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabelGoogleS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabelGoogleS.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.google.com");
            }
            catch
            {
                MessageBox.Show("Google is Not Available");
            }
        }

        private void RBYes_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void BTNRadioSub_Click(object sender, EventArgs e)
        {
            if (RBYes.Checked)
            {
                MessageBox.Show("Great No One Can Resist The Cuteness!");
            }
            else if (RBNo.Checked)
            {
                MessageBox.Show("Stop Trying to be Tough! Everyone Loves Cute Things!");
            }
            else if (RBLittle.Checked)
            {
                MessageBox.Show("The Cuteness is Irrisistable!");
            }
            else if (RBMissing.Checked)
            {
                MessageBox.Show("How did We Miss It!");
            }
            else if (RBStillBored.Checked)
            {
                MessageBox.Show("Are You Human?");
            }
        }

        private void BTNCute_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Cute = random.Next(1, 6);
            String path = Directory.GetCurrentDirectory();

            switch(Cute)
            {
                case 1:
                   {
                        string imagePath = Path.Combine(path, "Images", "BunnyRabbit.PNG");
                        pictureBox1.ImageLocation = imagePath;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                   }
                    break;
                case 2:
                   {
                        string imagePath = Path.Combine(path, "Images", "Koala.PNG");
                        pictureBox1.ImageLocation = imagePath;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    } 
                    break;
                case 3:
                   {
                        string imagePath = Path.Combine(path, "Images", "Panda.PNG");
                        pictureBox1.ImageLocation = imagePath;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                   }
                    break;
                case 4:
                   {
                        string imagePath = Path.Combine(path, "Images", "PuppyDog.PNG");
                        pictureBox1.ImageLocation = imagePath;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                   }
                    break;
                case 5:
                   {
                        string imagePath = Path.Combine(path, "Images", "KittyCat.PNG");
                        pictureBox1.ImageLocation = imagePath;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                   }
                    break;
            }
        }
        
    }
}
