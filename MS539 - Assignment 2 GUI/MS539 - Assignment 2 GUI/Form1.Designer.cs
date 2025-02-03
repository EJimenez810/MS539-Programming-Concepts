namespace MS539___Assignment_2_GUI
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
            this.labelName = new System.Windows.Forms.Label();
            this.TBNameInput = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.labelChkList = new System.Windows.Forms.Label();
            this.CBHappy = new System.Windows.Forms.CheckBox();
            this.CBSad = new System.Windows.Forms.CheckBox();
            this.CBMad = new System.Windows.Forms.CheckBox();
            this.CBBored = new System.Windows.Forms.CheckBox();
            this.BTNSubmitName = new System.Windows.Forms.Button();
            this.linkLabelGoogleS = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNCute = new System.Windows.Forms.Button();
            this.GBMoodChange = new System.Windows.Forms.GroupBox();
            this.RBYes = new System.Windows.Forms.RadioButton();
            this.RBNo = new System.Windows.Forms.RadioButton();
            this.RBLittle = new System.Windows.Forms.RadioButton();
            this.RBMissing = new System.Windows.Forms.RadioButton();
            this.RBStillBored = new System.Windows.Forms.RadioButton();
            this.BTNRadioSub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBMoodChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Location = new System.Drawing.Point(13, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // TBNameInput
            // 
            this.TBNameInput.Location = new System.Drawing.Point(58, 13);
            this.TBNameInput.Name = "TBNameInput";
            this.TBNameInput.Size = new System.Drawing.Size(100, 20);
            this.TBNameInput.TabIndex = 1;
            this.TBNameInput.TextChanged += new System.EventHandler(this.TBNameInput_TextChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(16, 41);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date:";
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(58, 41);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(100, 20);
            this.textbox1.TabIndex = 3;
            this.textbox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelChkList
            // 
            this.labelChkList.AutoSize = true;
            this.labelChkList.Location = new System.Drawing.Point(16, 133);
            this.labelChkList.Name = "labelChkList";
            this.labelChkList.Size = new System.Drawing.Size(207, 13);
            this.labelChkList.TabIndex = 5;
            this.labelChkList.Text = "Check All That Apply for your Mood Today";
            // 
            // CBHappy
            // 
            this.CBHappy.AutoSize = true;
            this.CBHappy.Location = new System.Drawing.Point(19, 166);
            this.CBHappy.Name = "CBHappy";
            this.CBHappy.Size = new System.Drawing.Size(57, 17);
            this.CBHappy.TabIndex = 6;
            this.CBHappy.Text = "Happy";
            this.CBHappy.UseVisualStyleBackColor = true;
            this.CBHappy.CheckedChanged += new System.EventHandler(this.CBHappy_CheckedChanged);
            // 
            // CBSad
            // 
            this.CBSad.AutoSize = true;
            this.CBSad.Location = new System.Drawing.Point(19, 190);
            this.CBSad.Name = "CBSad";
            this.CBSad.Size = new System.Drawing.Size(45, 17);
            this.CBSad.TabIndex = 7;
            this.CBSad.Text = "Sad";
            this.CBSad.UseVisualStyleBackColor = true;
            this.CBSad.CheckedChanged += new System.EventHandler(this.CBSad_CheckedChanged);
            // 
            // CBMad
            // 
            this.CBMad.AutoSize = true;
            this.CBMad.Location = new System.Drawing.Point(19, 214);
            this.CBMad.Name = "CBMad";
            this.CBMad.Size = new System.Drawing.Size(47, 17);
            this.CBMad.TabIndex = 8;
            this.CBMad.Text = "Mad";
            this.CBMad.UseVisualStyleBackColor = true;
            this.CBMad.CheckedChanged += new System.EventHandler(this.CBMad_CheckedChanged);
            // 
            // CBBored
            // 
            this.CBBored.AutoSize = true;
            this.CBBored.Location = new System.Drawing.Point(19, 238);
            this.CBBored.Name = "CBBored";
            this.CBBored.Size = new System.Drawing.Size(54, 17);
            this.CBBored.TabIndex = 9;
            this.CBBored.Text = "Bored";
            this.CBBored.UseVisualStyleBackColor = true;
            this.CBBored.CheckedChanged += new System.EventHandler(this.CBBored_CheckedChanged);
            // 
            // BTNSubmitName
            // 
            this.BTNSubmitName.Location = new System.Drawing.Point(45, 77);
            this.BTNSubmitName.Name = "BTNSubmitName";
            this.BTNSubmitName.Size = new System.Drawing.Size(99, 38);
            this.BTNSubmitName.TabIndex = 10;
            this.BTNSubmitName.Text = "Submit";
            this.BTNSubmitName.UseVisualStyleBackColor = true;
            this.BTNSubmitName.Click += new System.EventHandler(this.BTNSubmitName_Click);
            // 
            // linkLabelGoogleS
            // 
            this.linkLabelGoogleS.AutoSize = true;
            this.linkLabelGoogleS.Location = new System.Drawing.Point(244, 17);
            this.linkLabelGoogleS.Name = "linkLabelGoogleS";
            this.linkLabelGoogleS.Size = new System.Drawing.Size(84, 13);
            this.linkLabelGoogleS.TabIndex = 11;
            this.linkLabelGoogleS.TabStop = true;
            this.linkLabelGoogleS.Text = "Search Google?";
            this.linkLabelGoogleS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGoogleS_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(378, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 369);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // BTNCute
            // 
            this.BTNCute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BTNCute.Location = new System.Drawing.Point(533, 17);
            this.BTNCute.Name = "BTNCute";
            this.BTNCute.Size = new System.Drawing.Size(146, 37);
            this.BTNCute.TabIndex = 13;
            this.BTNCute.Text = "The Cuteness";
            this.BTNCute.UseVisualStyleBackColor = false;
            this.BTNCute.Click += new System.EventHandler(this.BTNCute_Click);
            // 
            // GBMoodChange
            // 
            this.GBMoodChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GBMoodChange.Controls.Add(this.RBStillBored);
            this.GBMoodChange.Controls.Add(this.RBMissing);
            this.GBMoodChange.Controls.Add(this.RBLittle);
            this.GBMoodChange.Controls.Add(this.RBNo);
            this.GBMoodChange.Controls.Add(this.RBYes);
            this.GBMoodChange.Location = new System.Drawing.Point(19, 261);
            this.GBMoodChange.Name = "GBMoodChange";
            this.GBMoodChange.Size = new System.Drawing.Size(214, 149);
            this.GBMoodChange.TabIndex = 14;
            this.GBMoodChange.TabStop = false;
            this.GBMoodChange.Text = "Did The Cuteness Change Your Mood?";
            // 
            // RBYes
            // 
            this.RBYes.AutoSize = true;
            this.RBYes.Location = new System.Drawing.Point(7, 20);
            this.RBYes.Name = "RBYes";
            this.RBYes.Size = new System.Drawing.Size(140, 17);
            this.RBYes.TabIndex = 0;
            this.RBYes.TabStop = true;
            this.RBYes.Text = "Aw! Of Course! So Cute!";
            this.RBYes.UseVisualStyleBackColor = true;
            this.RBYes.CheckedChanged += new System.EventHandler(this.RBYes_CheckedChanged);
            // 
            // RBNo
            // 
            this.RBNo.AutoSize = true;
            this.RBNo.Location = new System.Drawing.Point(7, 44);
            this.RBNo.Name = "RBNo";
            this.RBNo.Size = new System.Drawing.Size(157, 17);
            this.RBNo.TabIndex = 1;
            this.RBNo.TabStop = true;
            this.RBNo.Text = "No Dont Like The Cuteness";
            this.RBNo.UseVisualStyleBackColor = true;
            // 
            // RBLittle
            // 
            this.RBLittle.AutoSize = true;
            this.RBLittle.Location = new System.Drawing.Point(7, 68);
            this.RBLittle.Name = "RBLittle";
            this.RBLittle.Size = new System.Drawing.Size(149, 17);
            this.RBLittle.TabIndex = 2;
            this.RBLittle.TabStop = true;
            this.RBLittle.Text = "My Mood Changed a Little";
            this.RBLittle.UseVisualStyleBackColor = true;
            // 
            // RBMissing
            // 
            this.RBMissing.AutoSize = true;
            this.RBMissing.Location = new System.Drawing.Point(7, 92);
            this.RBMissing.Name = "RBMissing";
            this.RBMissing.Size = new System.Drawing.Size(128, 17);
            this.RBMissing.TabIndex = 3;
            this.RBMissing.TabStop = true;
            this.RBMissing.Text = "My Favorite is Missing";
            this.RBMissing.UseVisualStyleBackColor = true;
            // 
            // RBStillBored
            // 
            this.RBStillBored.AutoSize = true;
            this.RBStillBored.Location = new System.Drawing.Point(7, 116);
            this.RBStillBored.Name = "RBStillBored";
            this.RBStillBored.Size = new System.Drawing.Size(72, 17);
            this.RBStillBored.TabIndex = 4;
            this.RBStillBored.TabStop = true;
            this.RBStillBored.Text = "Still Bored";
            this.RBStillBored.UseVisualStyleBackColor = true;
            // 
            // BTNRadioSub
            // 
            this.BTNRadioSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BTNRadioSub.ForeColor = System.Drawing.Color.Blue;
            this.BTNRadioSub.Location = new System.Drawing.Point(45, 416);
            this.BTNRadioSub.Name = "BTNRadioSub";
            this.BTNRadioSub.Size = new System.Drawing.Size(161, 23);
            this.BTNRadioSub.TabIndex = 15;
            this.BTNRadioSub.Text = "Submit";
            this.BTNRadioSub.UseVisualStyleBackColor = false;
            this.BTNRadioSub.Click += new System.EventHandler(this.BTNRadioSub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNRadioSub);
            this.Controls.Add(this.GBMoodChange);
            this.Controls.Add(this.BTNCute);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelGoogleS);
            this.Controls.Add(this.BTNSubmitName);
            this.Controls.Add(this.CBBored);
            this.Controls.Add(this.CBMad);
            this.Controls.Add(this.CBSad);
            this.Controls.Add(this.CBHappy);
            this.Controls.Add(this.labelChkList);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.TBNameInput);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "MS539 - Assignment 2 GUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBMoodChange.ResumeLayout(false);
            this.GBMoodChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox TBNameInput;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Label labelChkList;
        private System.Windows.Forms.CheckBox CBHappy;
        private System.Windows.Forms.CheckBox CBSad;
        private System.Windows.Forms.CheckBox CBMad;
        private System.Windows.Forms.CheckBox CBBored;
        private System.Windows.Forms.Button BTNSubmitName;
        private System.Windows.Forms.LinkLabel linkLabelGoogleS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNCute;
        private System.Windows.Forms.GroupBox GBMoodChange;
        private System.Windows.Forms.RadioButton RBStillBored;
        private System.Windows.Forms.RadioButton RBMissing;
        private System.Windows.Forms.RadioButton RBLittle;
        private System.Windows.Forms.RadioButton RBNo;
        private System.Windows.Forms.RadioButton RBYes;
        private System.Windows.Forms.Button BTNRadioSub;
    }
}

