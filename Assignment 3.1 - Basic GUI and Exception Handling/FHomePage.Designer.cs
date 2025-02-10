namespace Assignment_3._1___Basic_GUI_and_Exception_Handling
{
    partial class FHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHomePage));
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelWelcomeBannerHome = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.BTNBudgetStrat = new System.Windows.Forms.Button();
            this.BTNTakeHomeP = new System.Windows.Forms.Button();
            this.BTNDebtStrategy = new System.Windows.Forms.Button();
            this.LabelGo2URL = new System.Windows.Forms.Label();
            this.TBGo2URL = new System.Windows.Forms.TextBox();
            this.BTNGo2URL = new System.Windows.Forms.Button();
            this.BTNNameSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(12, 69);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(128, 16);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Enter Your Name:";
            // 
            // LabelWelcomeBannerHome
            // 
            this.LabelWelcomeBannerHome.AutoSize = true;
            this.LabelWelcomeBannerHome.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcomeBannerHome.Location = new System.Drawing.Point(15, 13);
            this.LabelWelcomeBannerHome.Name = "LabelWelcomeBannerHome";
            this.LabelWelcomeBannerHome.Size = new System.Drawing.Size(324, 37);
            this.LabelWelcomeBannerHome.TabIndex = 1;
            this.LabelWelcomeBannerHome.Text = "Welcome to Financial Buddy!";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(146, 68);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(178, 20);
            this.TBName.TabIndex = 2;
            // 
            // BTNBudgetStrat
            // 
            this.BTNBudgetStrat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BTNBudgetStrat.Location = new System.Drawing.Point(707, 61);
            this.BTNBudgetStrat.Name = "BTNBudgetStrat";
            this.BTNBudgetStrat.Size = new System.Drawing.Size(119, 44);
            this.BTNBudgetStrat.TabIndex = 3;
            this.BTNBudgetStrat.Text = "To Budget Strategy ";
            this.BTNBudgetStrat.UseVisualStyleBackColor = false;
            this.BTNBudgetStrat.Click += new System.EventHandler(this.BTNBudgetStrat_Click);
            // 
            // BTNTakeHomeP
            // 
            this.BTNTakeHomeP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNTakeHomeP.Location = new System.Drawing.Point(707, 136);
            this.BTNTakeHomeP.Name = "BTNTakeHomeP";
            this.BTNTakeHomeP.Size = new System.Drawing.Size(119, 39);
            this.BTNTakeHomeP.TabIndex = 4;
            this.BTNTakeHomeP.Text = "Take Home Pay Calculator";
            this.BTNTakeHomeP.UseVisualStyleBackColor = false;
            this.BTNTakeHomeP.Click += new System.EventHandler(this.BTNTakeHomeP_Click);
            // 
            // BTNDebtStrategy
            // 
            this.BTNDebtStrategy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNDebtStrategy.Location = new System.Drawing.Point(707, 206);
            this.BTNDebtStrategy.Name = "BTNDebtStrategy";
            this.BTNDebtStrategy.Size = new System.Drawing.Size(119, 40);
            this.BTNDebtStrategy.TabIndex = 5;
            this.BTNDebtStrategy.Text = "Debt Strategy";
            this.BTNDebtStrategy.UseVisualStyleBackColor = false;
            this.BTNDebtStrategy.Click += new System.EventHandler(this.BTNDebtStrategy_Click);
            // 
            // LabelGo2URL
            // 
            this.LabelGo2URL.AutoSize = true;
            this.LabelGo2URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGo2URL.Location = new System.Drawing.Point(12, 147);
            this.LabelGo2URL.Name = "LabelGo2URL";
            this.LabelGo2URL.Size = new System.Drawing.Size(74, 15);
            this.LabelGo2URL.TabIndex = 6;
            this.LabelGo2URL.Text = "Go to Site:";
            // 
            // TBGo2URL
            // 
            this.TBGo2URL.Location = new System.Drawing.Point(92, 147);
            this.TBGo2URL.Name = "TBGo2URL";
            this.TBGo2URL.Size = new System.Drawing.Size(184, 20);
            this.TBGo2URL.TabIndex = 7;
            this.TBGo2URL.TextChanged += new System.EventHandler(this.TBGo2URL_TextChanged);
            // 
            // BTNGo2URL
            // 
            this.BTNGo2URL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNGo2URL.BackgroundImage")));
            this.BTNGo2URL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTNGo2URL.Location = new System.Drawing.Point(282, 139);
            this.BTNGo2URL.Name = "BTNGo2URL";
            this.BTNGo2URL.Size = new System.Drawing.Size(39, 33);
            this.BTNGo2URL.TabIndex = 8;
            this.BTNGo2URL.UseVisualStyleBackColor = true;
            this.BTNGo2URL.Click += new System.EventHandler(this.BTNGo2URL_Click);
            // 
            // BTNNameSubmit
            // 
            this.BTNNameSubmit.Location = new System.Drawing.Point(194, 94);
            this.BTNNameSubmit.Name = "BTNNameSubmit";
            this.BTNNameSubmit.Size = new System.Drawing.Size(85, 20);
            this.BTNNameSubmit.TabIndex = 9;
            this.BTNNameSubmit.Text = "Submit";
            this.BTNNameSubmit.UseVisualStyleBackColor = true;
            this.BTNNameSubmit.Click += new System.EventHandler(this.BTNNameSubmit_Click);
            // 
            // FHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(902, 477);
            this.Controls.Add(this.BTNNameSubmit);
            this.Controls.Add(this.BTNGo2URL);
            this.Controls.Add(this.TBGo2URL);
            this.Controls.Add(this.LabelGo2URL);
            this.Controls.Add(this.BTNDebtStrategy);
            this.Controls.Add(this.BTNTakeHomeP);
            this.Controls.Add(this.BTNBudgetStrat);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LabelWelcomeBannerHome);
            this.Controls.Add(this.LabelName);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FHomePage";
            this.Text = "Main Home Page ";
            this.Load += new System.EventHandler(this.FHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelWelcomeBannerHome;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Button BTNBudgetStrat;
        private System.Windows.Forms.Button BTNTakeHomeP;
        private System.Windows.Forms.Button BTNDebtStrategy;
        private System.Windows.Forms.Label LabelGo2URL;
        private System.Windows.Forms.TextBox TBGo2URL;
        private System.Windows.Forms.Button BTNGo2URL;
        private System.Windows.Forms.Button BTNNameSubmit;
    }
}

