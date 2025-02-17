namespace Assignment_4._1___Random_Number_Guessing_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNGuess = new System.Windows.Forms.Button();
            this.LBLInstructions = new System.Windows.Forms.Label();
            this.TBUserGuess = new System.Windows.Forms.TextBox();
            this.LBLResults = new System.Windows.Forms.Label();
            this.PBResult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBResult)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNGuess
            // 
            this.BTNGuess.Location = new System.Drawing.Point(315, 274);
            this.BTNGuess.Name = "BTNGuess";
            this.BTNGuess.Size = new System.Drawing.Size(153, 61);
            this.BTNGuess.TabIndex = 0;
            this.BTNGuess.Text = "Check Guess";
            this.BTNGuess.UseVisualStyleBackColor = true;
            this.BTNGuess.Click += new System.EventHandler(this.BTNGuess_Click);
            // 
            // LBLInstructions
            // 
            this.LBLInstructions.AutoSize = true;
            this.LBLInstructions.Location = new System.Drawing.Point(33, 22);
            this.LBLInstructions.Name = "LBLInstructions";
            this.LBLInstructions.Size = new System.Drawing.Size(153, 13);
            this.LBLInstructions.TabIndex = 1;
            this.LBLInstructions.Text = "Enter a number between 1 - 10";
            // 
            // TBUserGuess
            // 
            this.TBUserGuess.Location = new System.Drawing.Point(36, 39);
            this.TBUserGuess.Name = "TBUserGuess";
            this.TBUserGuess.Size = new System.Drawing.Size(150, 20);
            this.TBUserGuess.TabIndex = 2;
            // 
            // LBLResults
            // 
            this.LBLResults.AutoSize = true;
            this.LBLResults.Location = new System.Drawing.Point(556, 22);
            this.LBLResults.Name = "LBLResults";
            this.LBLResults.Size = new System.Drawing.Size(0, 13);
            this.LBLResults.TabIndex = 3;
            // 
            // PBResult
            // 
            this.PBResult.Location = new System.Drawing.Point(271, 22);
            this.PBResult.Name = "PBResult";
            this.PBResult.Size = new System.Drawing.Size(251, 246);
            this.PBResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBResult.TabIndex = 4;
            this.PBResult.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PBResult);
            this.Controls.Add(this.LBLResults);
            this.Controls.Add(this.TBUserGuess);
            this.Controls.Add(this.LBLInstructions);
            this.Controls.Add(this.BTNGuess);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PBResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNGuess;
        private System.Windows.Forms.Label LBLInstructions;
        private System.Windows.Forms.TextBox TBUserGuess;
        private System.Windows.Forms.Label LBLResults;
        private System.Windows.Forms.PictureBox PBResult;
    }
}

