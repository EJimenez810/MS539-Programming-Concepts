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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTakeHomePay));
            this.LabelTHP = new System.Windows.Forms.Label();
            this.BTNGoHome = new System.Windows.Forms.Button();
            this.LBLGrossIncome = new System.Windows.Forms.Label();
            this.TBGrossIncome = new System.Windows.Forms.TextBox();
            this.GBPreTaxDed = new System.Windows.Forms.GroupBox();
            this.LBL401K = new System.Windows.Forms.Label();
            this.TB401K = new System.Windows.Forms.TextBox();
            this.LBLMedicalPrem = new System.Windows.Forms.Label();
            this.LBLDentalPrem = new System.Windows.Forms.Label();
            this.TBMedical = new System.Windows.Forms.TextBox();
            this.TBDental = new System.Windows.Forms.TextBox();
            this.LBLVisionPrem = new System.Windows.Forms.Label();
            this.TBVision = new System.Windows.Forms.TextBox();
            this.LBLHSAFSA = new System.Windows.Forms.Label();
            this.TBHSAFSA = new System.Windows.Forms.TextBox();
            this.TBCommuter = new System.Windows.Forms.TextBox();
            this.LBLCommuterP = new System.Windows.Forms.Label();
            this.LBLTotalPreTax = new System.Windows.Forms.Label();
            this.GBPreTaxDed.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTHP
            // 
            this.LabelTHP.AutoSize = true;
            this.LabelTHP.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTHP.ForeColor = System.Drawing.Color.Green;
            this.LabelTHP.Location = new System.Drawing.Point(12, 9);
            this.LabelTHP.Name = "LabelTHP";
            this.LabelTHP.Size = new System.Drawing.Size(117, 37);
            this.LabelTHP.TabIndex = 0;
            this.LabelTHP.Text = "Welcome!";
            // 
            // BTNGoHome
            // 
            this.BTNGoHome.Location = new System.Drawing.Point(12, 415);
            this.BTNGoHome.Name = "BTNGoHome";
            this.BTNGoHome.Size = new System.Drawing.Size(75, 23);
            this.BTNGoHome.TabIndex = 1;
            this.BTNGoHome.Text = "Go Home";
            this.BTNGoHome.UseVisualStyleBackColor = true;
            this.BTNGoHome.Click += new System.EventHandler(this.BTNGoHome_Click);
            // 
            // LBLGrossIncome
            // 
            this.LBLGrossIncome.AutoSize = true;
            this.LBLGrossIncome.Location = new System.Drawing.Point(19, 50);
            this.LBLGrossIncome.Name = "LBLGrossIncome";
            this.LBLGrossIncome.Size = new System.Drawing.Size(75, 13);
            this.LBLGrossIncome.TabIndex = 2;
            this.LBLGrossIncome.Text = "Gross Income:";
            // 
            // TBGrossIncome
            // 
            this.TBGrossIncome.Location = new System.Drawing.Point(101, 50);
            this.TBGrossIncome.Name = "TBGrossIncome";
            this.TBGrossIncome.Size = new System.Drawing.Size(100, 20);
            this.TBGrossIncome.TabIndex = 3;
            // 
            // GBPreTaxDed
            // 
            this.GBPreTaxDed.Controls.Add(this.LBLTotalPreTax);
            this.GBPreTaxDed.Controls.Add(this.LBLCommuterP);
            this.GBPreTaxDed.Controls.Add(this.TBCommuter);
            this.GBPreTaxDed.Controls.Add(this.TBHSAFSA);
            this.GBPreTaxDed.Controls.Add(this.LBLHSAFSA);
            this.GBPreTaxDed.Controls.Add(this.TBVision);
            this.GBPreTaxDed.Controls.Add(this.LBLVisionPrem);
            this.GBPreTaxDed.Controls.Add(this.TBDental);
            this.GBPreTaxDed.Controls.Add(this.TBMedical);
            this.GBPreTaxDed.Controls.Add(this.LBLDentalPrem);
            this.GBPreTaxDed.Controls.Add(this.LBLMedicalPrem);
            this.GBPreTaxDed.Controls.Add(this.TB401K);
            this.GBPreTaxDed.Controls.Add(this.LBL401K);
            this.GBPreTaxDed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBPreTaxDed.Location = new System.Drawing.Point(19, 76);
            this.GBPreTaxDed.Name = "GBPreTaxDed";
            this.GBPreTaxDed.Size = new System.Drawing.Size(245, 247);
            this.GBPreTaxDed.TabIndex = 4;
            this.GBPreTaxDed.TabStop = false;
            this.GBPreTaxDed.Text = "Pre-Tax Deductions";
            // 
            // LBL401K
            // 
            this.LBL401K.AutoSize = true;
            this.LBL401K.Location = new System.Drawing.Point(7, 23);
            this.LBL401K.Name = "LBL401K";
            this.LBL401K.Size = new System.Drawing.Size(32, 13);
            this.LBL401K.TabIndex = 0;
            this.LBL401K.Text = "401K";
            // 
            // TB401K
            // 
            this.TB401K.Location = new System.Drawing.Point(85, 20);
            this.TB401K.Name = "TB401K";
            this.TB401K.Size = new System.Drawing.Size(100, 20);
            this.TB401K.TabIndex = 1;
            // 
            // LBLMedicalPrem
            // 
            this.LBLMedicalPrem.AutoSize = true;
            this.LBLMedicalPrem.Location = new System.Drawing.Point(7, 59);
            this.LBLMedicalPrem.Name = "LBLMedicalPrem";
            this.LBLMedicalPrem.Size = new System.Drawing.Size(71, 13);
            this.LBLMedicalPrem.TabIndex = 2;
            this.LBLMedicalPrem.Text = "Medical Prem";
            // 
            // LBLDentalPrem
            // 
            this.LBLDentalPrem.AutoSize = true;
            this.LBLDentalPrem.Location = new System.Drawing.Point(7, 95);
            this.LBLDentalPrem.Name = "LBLDentalPrem";
            this.LBLDentalPrem.Size = new System.Drawing.Size(65, 13);
            this.LBLDentalPrem.TabIndex = 3;
            this.LBLDentalPrem.Text = "Dental Prem";
            // 
            // TBMedical
            // 
            this.TBMedical.Location = new System.Drawing.Point(85, 52);
            this.TBMedical.Name = "TBMedical";
            this.TBMedical.Size = new System.Drawing.Size(100, 20);
            this.TBMedical.TabIndex = 4;
            // 
            // TBDental
            // 
            this.TBDental.Location = new System.Drawing.Point(85, 88);
            this.TBDental.Name = "TBDental";
            this.TBDental.Size = new System.Drawing.Size(100, 20);
            this.TBDental.TabIndex = 5;
            // 
            // LBLVisionPrem
            // 
            this.LBLVisionPrem.AutoSize = true;
            this.LBLVisionPrem.Location = new System.Drawing.Point(7, 128);
            this.LBLVisionPrem.Name = "LBLVisionPrem";
            this.LBLVisionPrem.Size = new System.Drawing.Size(62, 13);
            this.LBLVisionPrem.TabIndex = 6;
            this.LBLVisionPrem.Text = "Vision Prem";
            // 
            // TBVision
            // 
            this.TBVision.Location = new System.Drawing.Point(85, 121);
            this.TBVision.Name = "TBVision";
            this.TBVision.Size = new System.Drawing.Size(100, 20);
            this.TBVision.TabIndex = 7;
            // 
            // LBLHSAFSA
            // 
            this.LBLHSAFSA.AutoSize = true;
            this.LBLHSAFSA.Location = new System.Drawing.Point(7, 161);
            this.LBLHSAFSA.Name = "LBLHSAFSA";
            this.LBLHSAFSA.Size = new System.Drawing.Size(54, 13);
            this.LBLHSAFSA.TabIndex = 8;
            this.LBLHSAFSA.Text = "HSA/FSA";
            // 
            // TBHSAFSA
            // 
            this.TBHSAFSA.Location = new System.Drawing.Point(85, 154);
            this.TBHSAFSA.Name = "TBHSAFSA";
            this.TBHSAFSA.Size = new System.Drawing.Size(100, 20);
            this.TBHSAFSA.TabIndex = 9;
            // 
            // TBCommuter
            // 
            this.TBCommuter.Location = new System.Drawing.Point(85, 191);
            this.TBCommuter.Name = "TBCommuter";
            this.TBCommuter.Size = new System.Drawing.Size(100, 20);
            this.TBCommuter.TabIndex = 10;
            // 
            // LBLCommuterP
            // 
            this.LBLCommuterP.AutoSize = true;
            this.LBLCommuterP.Location = new System.Drawing.Point(7, 198);
            this.LBLCommuterP.Name = "LBLCommuterP";
            this.LBLCommuterP.Size = new System.Drawing.Size(78, 13);
            this.LBLCommuterP.TabIndex = 11;
            this.LBLCommuterP.Text = "Commuter Plan";
            // 
            // LBLTotalPreTax
            // 
            this.LBLTotalPreTax.AutoSize = true;
            this.LBLTotalPreTax.Location = new System.Drawing.Point(39, 220);
            this.LBLTotalPreTax.Name = "LBLTotalPreTax";
            this.LBLTotalPreTax.Size = new System.Drawing.Size(0, 13);
            this.LBLTotalPreTax.TabIndex = 13;
            // 
            // FTakeHomePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBPreTaxDed);
            this.Controls.Add(this.TBGrossIncome);
            this.Controls.Add(this.LBLGrossIncome);
            this.Controls.Add(this.BTNGoHome);
            this.Controls.Add(this.LabelTHP);
            this.DoubleBuffered = true;
            this.Name = "FTakeHomePay";
            this.Text = "FTakeHomePay";
            this.GBPreTaxDed.ResumeLayout(false);
            this.GBPreTaxDed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTHP;
        private System.Windows.Forms.Button BTNGoHome;
        private System.Windows.Forms.Label LBLGrossIncome;
        private System.Windows.Forms.TextBox TBGrossIncome;
        private System.Windows.Forms.GroupBox GBPreTaxDed;
        private System.Windows.Forms.Label LBLMedicalPrem;
        private System.Windows.Forms.TextBox TB401K;
        private System.Windows.Forms.Label LBL401K;
        private System.Windows.Forms.Label LBLVisionPrem;
        private System.Windows.Forms.TextBox TBDental;
        private System.Windows.Forms.TextBox TBMedical;
        private System.Windows.Forms.Label LBLDentalPrem;
        private System.Windows.Forms.TextBox TBVision;
        private System.Windows.Forms.Label LBLCommuterP;
        private System.Windows.Forms.TextBox TBCommuter;
        private System.Windows.Forms.TextBox TBHSAFSA;
        private System.Windows.Forms.Label LBLHSAFSA;
        private System.Windows.Forms.Label LBLTotalPreTax;
    }
}