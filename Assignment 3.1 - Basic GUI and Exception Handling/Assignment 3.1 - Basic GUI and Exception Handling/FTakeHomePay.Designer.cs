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
            this.LBLTotalPreTax = new System.Windows.Forms.Label();
            this.LBLCommuterP = new System.Windows.Forms.Label();
            this.TBCommuter = new System.Windows.Forms.TextBox();
            this.TBHSAFSA = new System.Windows.Forms.TextBox();
            this.LBLHSAFSA = new System.Windows.Forms.Label();
            this.TBVision = new System.Windows.Forms.TextBox();
            this.LBLVisionPrem = new System.Windows.Forms.Label();
            this.TBDental = new System.Windows.Forms.TextBox();
            this.TBMedical = new System.Windows.Forms.TextBox();
            this.LBLDentalPrem = new System.Windows.Forms.Label();
            this.LBLMedicalPrem = new System.Windows.Forms.Label();
            this.TB401K = new System.Windows.Forms.TextBox();
            this.LBL401K = new System.Windows.Forms.Label();
            this.GBPostTaxDed = new System.Windows.Forms.GroupBox();
            this.LBLTotalPostTax = new System.Windows.Forms.Label();
            this.TBPSL = new System.Windows.Forms.TextBox();
            this.TBLegal = new System.Windows.Forms.TextBox();
            this.TBLTD = new System.Windows.Forms.TextBox();
            this.TBDepLife = new System.Windows.Forms.TextBox();
            this.TBSpsLife = new System.Windows.Forms.TextBox();
            this.TBHosInd = new System.Windows.Forms.TextBox();
            this.TBACCIns = new System.Windows.Forms.TextBox();
            this.TBCritILL = new System.Windows.Forms.TextBox();
            this.TBADnD = new System.Windows.Forms.TextBox();
            this.LBLPSL = new System.Windows.Forms.Label();
            this.LBLLegal = new System.Windows.Forms.Label();
            this.LBLLTD = new System.Windows.Forms.Label();
            this.LBLDepLife = new System.Windows.Forms.Label();
            this.LBLSpsLife = new System.Windows.Forms.Label();
            this.LBLHosInd = new System.Windows.Forms.Label();
            this.LBLACCIns = new System.Windows.Forms.Label();
            this.LBLCritILL = new System.Windows.Forms.Label();
            this.LBLADnD = new System.Windows.Forms.Label();
            this.CBStateIncTax = new System.Windows.Forms.ComboBox();
            this.CBFilingStat = new System.Windows.Forms.ComboBox();
            this.LBLSState = new System.Windows.Forms.Label();
            this.LBLFilingStat = new System.Windows.Forms.Label();
            this.BTNCalcNetInc = new System.Windows.Forms.Button();
            this.LBLStateTax = new System.Windows.Forms.Label();
            this.LBLFedTax = new System.Windows.Forms.Label();
            this.LBLTakeHomePay = new System.Windows.Forms.Label();
            this.CBPayPeriod = new System.Windows.Forms.ComboBox();
            this.LBLPayPeriod = new System.Windows.Forms.Label();
            this.GBPreTaxDed.SuspendLayout();
            this.GBPostTaxDed.SuspendLayout();
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
            this.BTNGoHome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGoHome.Location = new System.Drawing.Point(5, 1002);
            this.BTNGoHome.Name = "BTNGoHome";
            this.BTNGoHome.Size = new System.Drawing.Size(107, 47);
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
            this.GBPreTaxDed.Size = new System.Drawing.Size(267, 247);
            this.GBPreTaxDed.TabIndex = 4;
            this.GBPreTaxDed.TabStop = false;
            this.GBPreTaxDed.Text = "Pre-Tax Deductions";
            // 
            // LBLTotalPreTax
            // 
            this.LBLTotalPreTax.AutoSize = true;
            this.LBLTotalPreTax.Location = new System.Drawing.Point(39, 220);
            this.LBLTotalPreTax.Name = "LBLTotalPreTax";
            this.LBLTotalPreTax.Size = new System.Drawing.Size(0, 13);
            this.LBLTotalPreTax.TabIndex = 13;
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
            // TBCommuter
            // 
            this.TBCommuter.Location = new System.Drawing.Point(125, 191);
            this.TBCommuter.Name = "TBCommuter";
            this.TBCommuter.Size = new System.Drawing.Size(136, 20);
            this.TBCommuter.TabIndex = 10;
            // 
            // TBHSAFSA
            // 
            this.TBHSAFSA.Location = new System.Drawing.Point(125, 154);
            this.TBHSAFSA.Name = "TBHSAFSA";
            this.TBHSAFSA.Size = new System.Drawing.Size(136, 20);
            this.TBHSAFSA.TabIndex = 9;
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
            // TBVision
            // 
            this.TBVision.Location = new System.Drawing.Point(125, 121);
            this.TBVision.Name = "TBVision";
            this.TBVision.Size = new System.Drawing.Size(136, 20);
            this.TBVision.TabIndex = 7;
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
            // TBDental
            // 
            this.TBDental.Location = new System.Drawing.Point(125, 88);
            this.TBDental.Name = "TBDental";
            this.TBDental.Size = new System.Drawing.Size(136, 20);
            this.TBDental.TabIndex = 5;
            // 
            // TBMedical
            // 
            this.TBMedical.Location = new System.Drawing.Point(125, 52);
            this.TBMedical.Name = "TBMedical";
            this.TBMedical.Size = new System.Drawing.Size(136, 20);
            this.TBMedical.TabIndex = 4;
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
            // LBLMedicalPrem
            // 
            this.LBLMedicalPrem.AutoSize = true;
            this.LBLMedicalPrem.Location = new System.Drawing.Point(7, 59);
            this.LBLMedicalPrem.Name = "LBLMedicalPrem";
            this.LBLMedicalPrem.Size = new System.Drawing.Size(71, 13);
            this.LBLMedicalPrem.TabIndex = 2;
            this.LBLMedicalPrem.Text = "Medical Prem";
            // 
            // TB401K
            // 
            this.TB401K.Location = new System.Drawing.Point(125, 20);
            this.TB401K.Name = "TB401K";
            this.TB401K.Size = new System.Drawing.Size(136, 20);
            this.TB401K.TabIndex = 1;
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
            // GBPostTaxDed
            // 
            this.GBPostTaxDed.BackColor = System.Drawing.SystemColors.Control;
            this.GBPostTaxDed.Controls.Add(this.LBLTotalPostTax);
            this.GBPostTaxDed.Controls.Add(this.TBPSL);
            this.GBPostTaxDed.Controls.Add(this.TBLegal);
            this.GBPostTaxDed.Controls.Add(this.TBLTD);
            this.GBPostTaxDed.Controls.Add(this.TBDepLife);
            this.GBPostTaxDed.Controls.Add(this.TBSpsLife);
            this.GBPostTaxDed.Controls.Add(this.TBHosInd);
            this.GBPostTaxDed.Controls.Add(this.TBACCIns);
            this.GBPostTaxDed.Controls.Add(this.TBCritILL);
            this.GBPostTaxDed.Controls.Add(this.TBADnD);
            this.GBPostTaxDed.Controls.Add(this.LBLPSL);
            this.GBPostTaxDed.Controls.Add(this.LBLLegal);
            this.GBPostTaxDed.Controls.Add(this.LBLLTD);
            this.GBPostTaxDed.Controls.Add(this.LBLDepLife);
            this.GBPostTaxDed.Controls.Add(this.LBLSpsLife);
            this.GBPostTaxDed.Controls.Add(this.LBLHosInd);
            this.GBPostTaxDed.Controls.Add(this.LBLACCIns);
            this.GBPostTaxDed.Controls.Add(this.LBLCritILL);
            this.GBPostTaxDed.Controls.Add(this.LBLADnD);
            this.GBPostTaxDed.Location = new System.Drawing.Point(19, 329);
            this.GBPostTaxDed.Name = "GBPostTaxDed";
            this.GBPostTaxDed.Size = new System.Drawing.Size(273, 323);
            this.GBPostTaxDed.TabIndex = 5;
            this.GBPostTaxDed.TabStop = false;
            this.GBPostTaxDed.Text = "Post-Tax Deductions";
            // 
            // LBLTotalPostTax
            // 
            this.LBLTotalPostTax.AutoSize = true;
            this.LBLTotalPostTax.Location = new System.Drawing.Point(10, 304);
            this.LBLTotalPostTax.Name = "LBLTotalPostTax";
            this.LBLTotalPostTax.Size = new System.Drawing.Size(0, 13);
            this.LBLTotalPostTax.TabIndex = 18;
            // 
            // TBPSL
            // 
            this.TBPSL.Location = new System.Drawing.Point(125, 275);
            this.TBPSL.Name = "TBPSL";
            this.TBPSL.Size = new System.Drawing.Size(142, 20);
            this.TBPSL.TabIndex = 17;
            // 
            // TBLegal
            // 
            this.TBLegal.Location = new System.Drawing.Point(125, 243);
            this.TBLegal.Name = "TBLegal";
            this.TBLegal.Size = new System.Drawing.Size(142, 20);
            this.TBLegal.TabIndex = 16;
            // 
            // TBLTD
            // 
            this.TBLTD.Location = new System.Drawing.Point(125, 214);
            this.TBLTD.Name = "TBLTD";
            this.TBLTD.Size = new System.Drawing.Size(142, 20);
            this.TBLTD.TabIndex = 15;
            // 
            // TBDepLife
            // 
            this.TBDepLife.Location = new System.Drawing.Point(125, 184);
            this.TBDepLife.Name = "TBDepLife";
            this.TBDepLife.Size = new System.Drawing.Size(142, 20);
            this.TBDepLife.TabIndex = 14;
            // 
            // TBSpsLife
            // 
            this.TBSpsLife.Location = new System.Drawing.Point(125, 151);
            this.TBSpsLife.Name = "TBSpsLife";
            this.TBSpsLife.Size = new System.Drawing.Size(142, 20);
            this.TBSpsLife.TabIndex = 13;
            // 
            // TBHosInd
            // 
            this.TBHosInd.Location = new System.Drawing.Point(125, 121);
            this.TBHosInd.Name = "TBHosInd";
            this.TBHosInd.Size = new System.Drawing.Size(142, 20);
            this.TBHosInd.TabIndex = 12;
            // 
            // TBACCIns
            // 
            this.TBACCIns.Location = new System.Drawing.Point(125, 92);
            this.TBACCIns.Name = "TBACCIns";
            this.TBACCIns.Size = new System.Drawing.Size(142, 20);
            this.TBACCIns.TabIndex = 11;
            // 
            // TBCritILL
            // 
            this.TBCritILL.Location = new System.Drawing.Point(125, 59);
            this.TBCritILL.Name = "TBCritILL";
            this.TBCritILL.Size = new System.Drawing.Size(142, 20);
            this.TBCritILL.TabIndex = 10;
            // 
            // TBADnD
            // 
            this.TBADnD.Location = new System.Drawing.Point(125, 26);
            this.TBADnD.Name = "TBADnD";
            this.TBADnD.Size = new System.Drawing.Size(142, 20);
            this.TBADnD.TabIndex = 9;
            // 
            // LBLPSL
            // 
            this.LBLPSL.AutoSize = true;
            this.LBLPSL.Location = new System.Drawing.Point(7, 275);
            this.LBLPSL.Name = "LBLPSL";
            this.LBLPSL.Size = new System.Drawing.Size(93, 13);
            this.LBLPSL.TabIndex = 8;
            this.LBLPSL.Text = "Post-Supp Life Ins";
            // 
            // LBLLegal
            // 
            this.LBLLegal.AutoSize = true;
            this.LBLLegal.Location = new System.Drawing.Point(7, 246);
            this.LBLLegal.Name = "LBLLegal";
            this.LBLLegal.Size = new System.Drawing.Size(82, 13);
            this.LBLLegal.TabIndex = 7;
            this.LBLLegal.Text = "Group Legal Ins";
            // 
            // LBLLTD
            // 
            this.LBLLTD.AutoSize = true;
            this.LBLLTD.Location = new System.Drawing.Point(7, 217);
            this.LBLLTD.Name = "LBLLTD";
            this.LBLLTD.Size = new System.Drawing.Size(93, 13);
            this.LBLLTD.TabIndex = 6;
            this.LBLLTD.Text = "Long-Term Dis Ins";
            // 
            // LBLDepLife
            // 
            this.LBLDepLife.AutoSize = true;
            this.LBLDepLife.Location = new System.Drawing.Point(7, 187);
            this.LBLDepLife.Name = "LBLDepLife";
            this.LBLDepLife.Size = new System.Drawing.Size(97, 13);
            this.LBLDepLife.TabIndex = 5;
            this.LBLDepLife.Text = "Dependent Life Ins";
            // 
            // LBLSpsLife
            // 
            this.LBLSpsLife.AutoSize = true;
            this.LBLSpsLife.Location = new System.Drawing.Point(7, 154);
            this.LBLSpsLife.Name = "LBLSpsLife";
            this.LBLSpsLife.Size = new System.Drawing.Size(80, 13);
            this.LBLSpsLife.TabIndex = 4;
            this.LBLSpsLife.Text = "Spouse Life Ins";
            // 
            // LBLHosInd
            // 
            this.LBLHosInd.AutoSize = true;
            this.LBLHosInd.Location = new System.Drawing.Point(7, 121);
            this.LBLHosInd.Name = "LBLHosInd";
            this.LBLHosInd.Size = new System.Drawing.Size(86, 13);
            this.LBLHosInd.TabIndex = 3;
            this.LBLHosInd.Text = "Hosp. Indem. ins";
            // 
            // LBLACCIns
            // 
            this.LBLACCIns.AutoSize = true;
            this.LBLACCIns.Location = new System.Drawing.Point(7, 95);
            this.LBLACCIns.Name = "LBLACCIns";
            this.LBLACCIns.Size = new System.Drawing.Size(66, 13);
            this.LBLACCIns.TabIndex = 2;
            this.LBLACCIns.Text = "Accident Ins";
            // 
            // LBLCritILL
            // 
            this.LBLCritILL.AutoSize = true;
            this.LBLCritILL.Location = new System.Drawing.Point(7, 59);
            this.LBLCritILL.Name = "LBLCritILL";
            this.LBLCritILL.Size = new System.Drawing.Size(65, 13);
            this.LBLCritILL.TabIndex = 1;
            this.LBLCritILL.Text = "Critical Ill Ins";
            // 
            // LBLADnD
            // 
            this.LBLADnD.AutoSize = true;
            this.LBLADnD.Location = new System.Drawing.Point(7, 26);
            this.LBLADnD.Name = "LBLADnD";
            this.LBLADnD.Size = new System.Drawing.Size(47, 13);
            this.LBLADnD.TabIndex = 0;
            this.LBLADnD.Text = "ADD Ins";
            // 
            // CBStateIncTax
            // 
            this.CBStateIncTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStateIncTax.FormattingEnabled = true;
            this.CBStateIncTax.Location = new System.Drawing.Point(310, 73);
            this.CBStateIncTax.Name = "CBStateIncTax";
            this.CBStateIncTax.Size = new System.Drawing.Size(121, 21);
            this.CBStateIncTax.Sorted = true;
            this.CBStateIncTax.TabIndex = 6;
            // 
            // CBFilingStat
            // 
            this.CBFilingStat.FormattingEnabled = true;
            this.CBFilingStat.Location = new System.Drawing.Point(310, 151);
            this.CBFilingStat.Name = "CBFilingStat";
            this.CBFilingStat.Size = new System.Drawing.Size(121, 21);
            this.CBFilingStat.TabIndex = 7;
            // 
            // LBLSState
            // 
            this.LBLSState.AutoSize = true;
            this.LBLSState.Location = new System.Drawing.Point(310, 57);
            this.LBLSState.Name = "LBLSState";
            this.LBLSState.Size = new System.Drawing.Size(90, 13);
            this.LBLSState.TabIndex = 8;
            this.LBLSState.Text = "Select Your State";
            // 
            // LBLFilingStat
            // 
            this.LBLFilingStat.AutoSize = true;
            this.LBLFilingStat.Location = new System.Drawing.Point(309, 135);
            this.LBLFilingStat.Name = "LBLFilingStat";
            this.LBLFilingStat.Size = new System.Drawing.Size(122, 13);
            this.LBLFilingStat.TabIndex = 9;
            this.LBLFilingStat.Text = "Select Your Filing Status";
            // 
            // BTNCalcNetInc
            // 
            this.BTNCalcNetInc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTNCalcNetInc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNCalcNetInc.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCalcNetInc.Location = new System.Drawing.Point(310, 428);
            this.BTNCalcNetInc.Name = "BTNCalcNetInc";
            this.BTNCalcNetInc.Size = new System.Drawing.Size(200, 105);
            this.BTNCalcNetInc.TabIndex = 10;
            this.BTNCalcNetInc.Text = "Calculate Net Income";
            this.BTNCalcNetInc.UseVisualStyleBackColor = false;
            this.BTNCalcNetInc.Click += new System.EventHandler(this.BTNCalcNetInc_Click);
            // 
            // LBLStateTax
            // 
            this.LBLStateTax.AutoSize = true;
            this.LBLStateTax.Location = new System.Drawing.Point(313, 101);
            this.LBLStateTax.Name = "LBLStateTax";
            this.LBLStateTax.Size = new System.Drawing.Size(56, 13);
            this.LBLStateTax.TabIndex = 11;
            this.LBLStateTax.Text = "State Tax:";
            // 
            // LBLFedTax
            // 
            this.LBLFedTax.AutoSize = true;
            this.LBLFedTax.Location = new System.Drawing.Point(310, 197);
            this.LBLFedTax.Name = "LBLFedTax";
            this.LBLFedTax.Size = new System.Drawing.Size(66, 13);
            this.LBLFedTax.TabIndex = 12;
            this.LBLFedTax.Text = "Federal Tax:";
            // 
            // LBLTakeHomePay
            // 
            this.LBLTakeHomePay.AutoSize = true;
            this.LBLTakeHomePay.Location = new System.Drawing.Point(310, 329);
            this.LBLTakeHomePay.Name = "LBLTakeHomePay";
            this.LBLTakeHomePay.Size = new System.Drawing.Size(87, 13);
            this.LBLTakeHomePay.TabIndex = 13;
            this.LBLTakeHomePay.Text = "Take Home Pay:";
            // 
            // CBPayPeriod
            // 
            this.CBPayPeriod.FormattingEnabled = true;
            this.CBPayPeriod.Location = new System.Drawing.Point(312, 253);
            this.CBPayPeriod.Name = "CBPayPeriod";
            this.CBPayPeriod.Size = new System.Drawing.Size(121, 21);
            this.CBPayPeriod.TabIndex = 14;
            // 
            // LBLPayPeriod
            // 
            this.LBLPayPeriod.AutoSize = true;
            this.LBLPayPeriod.Location = new System.Drawing.Point(309, 237);
            this.LBLPayPeriod.Name = "LBLPayPeriod";
            this.LBLPayPeriod.Size = new System.Drawing.Size(91, 13);
            this.LBLPayPeriod.TabIndex = 15;
            this.LBLPayPeriod.Text = "Select Pay Period";
            // 
            // FTakeHomePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1257, 1061);
            this.Controls.Add(this.LBLPayPeriod);
            this.Controls.Add(this.CBPayPeriod);
            this.Controls.Add(this.LBLTakeHomePay);
            this.Controls.Add(this.LBLFedTax);
            this.Controls.Add(this.LBLStateTax);
            this.Controls.Add(this.BTNCalcNetInc);
            this.Controls.Add(this.LBLFilingStat);
            this.Controls.Add(this.LBLSState);
            this.Controls.Add(this.CBFilingStat);
            this.Controls.Add(this.CBStateIncTax);
            this.Controls.Add(this.GBPostTaxDed);
            this.Controls.Add(this.GBPreTaxDed);
            this.Controls.Add(this.TBGrossIncome);
            this.Controls.Add(this.LBLGrossIncome);
            this.Controls.Add(this.BTNGoHome);
            this.Controls.Add(this.LabelTHP);
            this.DoubleBuffered = true;
            this.Name = "FTakeHomePay";
            this.Text = "FTakeHomePay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FTakeHomePay_Load);
            this.GBPreTaxDed.ResumeLayout(false);
            this.GBPreTaxDed.PerformLayout();
            this.GBPostTaxDed.ResumeLayout(false);
            this.GBPostTaxDed.PerformLayout();
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
        private System.Windows.Forms.GroupBox GBPostTaxDed;
        private System.Windows.Forms.Label LBLADnD;
        private System.Windows.Forms.Label LBLHosInd;
        private System.Windows.Forms.Label LBLACCIns;
        private System.Windows.Forms.Label LBLCritILL;
        private System.Windows.Forms.Label LBLLTD;
        private System.Windows.Forms.Label LBLDepLife;
        private System.Windows.Forms.Label LBLSpsLife;
        private System.Windows.Forms.Label LBLTotalPostTax;
        private System.Windows.Forms.TextBox TBPSL;
        private System.Windows.Forms.TextBox TBLegal;
        private System.Windows.Forms.TextBox TBLTD;
        private System.Windows.Forms.TextBox TBDepLife;
        private System.Windows.Forms.TextBox TBSpsLife;
        private System.Windows.Forms.TextBox TBHosInd;
        private System.Windows.Forms.TextBox TBACCIns;
        private System.Windows.Forms.TextBox TBCritILL;
        private System.Windows.Forms.TextBox TBADnD;
        private System.Windows.Forms.Label LBLPSL;
        private System.Windows.Forms.Label LBLLegal;
        private System.Windows.Forms.ComboBox CBStateIncTax;
        private System.Windows.Forms.ComboBox CBFilingStat;
        private System.Windows.Forms.Label LBLSState;
        private System.Windows.Forms.Label LBLFilingStat;
        private System.Windows.Forms.Button BTNCalcNetInc;
        private System.Windows.Forms.Label LBLStateTax;
        private System.Windows.Forms.Label LBLFedTax;
        private System.Windows.Forms.Label LBLTakeHomePay;
        private System.Windows.Forms.ComboBox CBPayPeriod;
        private System.Windows.Forms.Label LBLPayPeriod;
    }
}