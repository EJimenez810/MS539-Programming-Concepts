namespace Assignment_3._1___Basic_GUI_and_Exception_Handling
{
    partial class FBudgetStrategy
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
            this.LabelBSW = new System.Windows.Forms.Label();
            this.BTNGoHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelBSW
            // 
            this.LabelBSW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelBSW.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBSW.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.LabelBSW.Location = new System.Drawing.Point(13, 13);
            this.LabelBSW.Name = "LabelBSW";
            this.LabelBSW.Size = new System.Drawing.Size(141, 48);
            this.LabelBSW.TabIndex = 0;
            this.LabelBSW.Text = "Welcome!";
            this.LabelBSW.Click += new System.EventHandler(this.LabelBSW_Click);
            // 
            // BTNGoHome
            // 
            this.BTNGoHome.Location = new System.Drawing.Point(20, 92);
            this.BTNGoHome.Name = "BTNGoHome";
            this.BTNGoHome.Size = new System.Drawing.Size(75, 23);
            this.BTNGoHome.TabIndex = 1;
            this.BTNGoHome.Text = "Go to Home Page";
            this.BTNGoHome.UseVisualStyleBackColor = true;
            this.BTNGoHome.Click += new System.EventHandler(this.BTNGoHome_Click);
            // 
            // FBudgetStrategy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNGoHome);
            this.Controls.Add(this.LabelBSW);
            this.Name = "FBudgetStrategy";
            this.Text = "FBudgetStrategy";
            this.Load += new System.EventHandler(this.FBudgetStrategy_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelBSW;
        private System.Windows.Forms.Button BTNGoHome;
    }
}