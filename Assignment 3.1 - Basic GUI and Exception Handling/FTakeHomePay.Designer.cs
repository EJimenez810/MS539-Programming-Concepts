namespace Assignment_3._1___Basic_GUI_and_Exception_Handling
{
    partial class FTakeHomePay
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
            this.LabelTHP = new System.Windows.Forms.Label();
            this.BTNGoHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTHP
            // 
            this.LabelTHP.AutoSize = true;
            this.LabelTHP.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTHP.ForeColor = System.Drawing.Color.Green;
            this.LabelTHP.Location = new System.Drawing.Point(13, 13);
            this.LabelTHP.Name = "LabelTHP";
            this.LabelTHP.Size = new System.Drawing.Size(117, 37);
            this.LabelTHP.TabIndex = 0;
            this.LabelTHP.Text = "Welcome!";
            // 
            // BTNGoHome
            // 
            this.BTNGoHome.Location = new System.Drawing.Point(20, 76);
            this.BTNGoHome.Name = "BTNGoHome";
            this.BTNGoHome.Size = new System.Drawing.Size(75, 23);
            this.BTNGoHome.TabIndex = 1;
            this.BTNGoHome.Text = "Go Home";
            this.BTNGoHome.UseVisualStyleBackColor = true;
            this.BTNGoHome.Click += new System.EventHandler(this.BTNGoHome_Click);
            // 
            // FTakeHomePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNGoHome);
            this.Controls.Add(this.LabelTHP);
            this.Name = "FTakeHomePay";
            this.Text = "FTakeHomePay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTHP;
        private System.Windows.Forms.Button BTNGoHome;
    }
}