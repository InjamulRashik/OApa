namespace Oapa_final_project
{
    partial class RegistrationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationView));
            this.labelReg = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.jMaterialTextboxName = new JMaterialTextbox.JMaterialTextbox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.jMaterialTextboxNumber = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextboxPin = new JMaterialTextbox.JMaterialTextbox();
            this.labelPin = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.comboBoxProf = new System.Windows.Forms.ComboBox();
            this.labelProf = new System.Windows.Forms.Label();
            this.jThinButtonRegistration = new JThinButton.JThinButton();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.BackColor = System.Drawing.Color.Transparent;
            this.labelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReg.ForeColor = System.Drawing.Color.Indigo;
            this.labelReg.Location = new System.Drawing.Point(80, 141);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(199, 25);
            this.labelReg.TabIndex = 15;
            this.labelReg.Text = "Registration Form";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Indigo;
            this.labelName.Location = new System.Drawing.Point(22, 203);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(62, 18);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Name :";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // jMaterialTextboxName
            // 
            this.jMaterialTextboxName.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextboxName.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextboxName.ForeColors = System.Drawing.Color.Indigo;
            this.jMaterialTextboxName.HintText = "";
            this.jMaterialTextboxName.IsPassword = false;
            this.jMaterialTextboxName.LineBackColor = System.Drawing.Color.Indigo;
            this.jMaterialTextboxName.LineThickness = 3;
            this.jMaterialTextboxName.Location = new System.Drawing.Point(116, 203);
            this.jMaterialTextboxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jMaterialTextboxName.MaxLength = 32767;
            this.jMaterialTextboxName.Name = "jMaterialTextboxName";
            this.jMaterialTextboxName.OnFocusedColor = System.Drawing.Color.Purple;
            this.jMaterialTextboxName.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.jMaterialTextboxName.ReadOnly = false;
            this.jMaterialTextboxName.Size = new System.Drawing.Size(162, 23);
            this.jMaterialTextboxName.TabIndex = 17;
            this.jMaterialTextboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextboxName.TextName = "";
            this.jMaterialTextboxName.Load += new System.EventHandler(this.jMaterialTextboxName_Load);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.ForeColor = System.Drawing.Color.Indigo;
            this.labelNumber.Location = new System.Drawing.Point(22, 243);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(77, 18);
            this.labelNumber.TabIndex = 18;
            this.labelNumber.Text = "Number :";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.Indigo;
            this.labelGender.Location = new System.Drawing.Point(22, 320);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(73, 18);
            this.labelGender.TabIndex = 20;
            this.labelGender.Text = "Gender :";
            // 
            // jMaterialTextboxNumber
            // 
            this.jMaterialTextboxNumber.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextboxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextboxNumber.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextboxNumber.ForeColors = System.Drawing.Color.Indigo;
            this.jMaterialTextboxNumber.HintText = null;
            this.jMaterialTextboxNumber.IsPassword = false;
            this.jMaterialTextboxNumber.LineBackColor = System.Drawing.Color.Indigo;
            this.jMaterialTextboxNumber.LineThickness = 3;
            this.jMaterialTextboxNumber.Location = new System.Drawing.Point(116, 244);
            this.jMaterialTextboxNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jMaterialTextboxNumber.MaxLength = 32767;
            this.jMaterialTextboxNumber.Name = "jMaterialTextboxNumber";
            this.jMaterialTextboxNumber.OnFocusedColor = System.Drawing.Color.Purple;
            this.jMaterialTextboxNumber.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.jMaterialTextboxNumber.ReadOnly = false;
            this.jMaterialTextboxNumber.Size = new System.Drawing.Size(162, 22);
            this.jMaterialTextboxNumber.TabIndex = 21;
            this.jMaterialTextboxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextboxNumber.TextName = "";
            this.jMaterialTextboxNumber.Load += new System.EventHandler(this.jMaterialTextboxNumber_Load);
            // 
            // jMaterialTextboxPin
            // 
            this.jMaterialTextboxPin.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextboxPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextboxPin.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMaterialTextboxPin.ForeColors = System.Drawing.Color.Indigo;
            this.jMaterialTextboxPin.HintText = null;
            this.jMaterialTextboxPin.IsPassword = false;
            this.jMaterialTextboxPin.LineBackColor = System.Drawing.Color.Indigo;
            this.jMaterialTextboxPin.LineThickness = 3;
            this.jMaterialTextboxPin.Location = new System.Drawing.Point(116, 286);
            this.jMaterialTextboxPin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jMaterialTextboxPin.MaxLength = 32767;
            this.jMaterialTextboxPin.Name = "jMaterialTextboxPin";
            this.jMaterialTextboxPin.OnFocusedColor = System.Drawing.Color.Purple;
            this.jMaterialTextboxPin.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.jMaterialTextboxPin.ReadOnly = false;
            this.jMaterialTextboxPin.Size = new System.Drawing.Size(162, 22);
            this.jMaterialTextboxPin.TabIndex = 22;
            this.jMaterialTextboxPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextboxPin.TextName = "";
            this.jMaterialTextboxPin.Load += new System.EventHandler(this.jMaterialTextboxPin_Load);
            // 
            // labelPin
            // 
            this.labelPin.AutoSize = true;
            this.labelPin.BackColor = System.Drawing.Color.Transparent;
            this.labelPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPin.ForeColor = System.Drawing.Color.Indigo;
            this.labelPin.Location = new System.Drawing.Point(22, 285);
            this.labelPin.Name = "labelPin";
            this.labelPin.Size = new System.Drawing.Size(42, 18);
            this.labelPin.TabIndex = 19;
            this.labelPin.Text = "Pin :";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.ForeColor = System.Drawing.Color.Indigo;
            this.radioButtonMale.Location = new System.Drawing.Point(6, 5);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(60, 20);
            this.radioButtonMale.TabIndex = 23;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = false;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.ForeColor = System.Drawing.Color.Indigo;
            this.radioButtonFemale.Location = new System.Drawing.Point(70, 5);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(78, 20);
            this.radioButtonFemale.TabIndex = 24;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = false;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxGender.Location = new System.Drawing.Point(112, 320);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(170, 28);
            this.groupBoxGender.TabIndex = 25;
            this.groupBoxGender.TabStop = false;
            // 
            // comboBoxProf
            // 
            this.comboBoxProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProf.ForeColor = System.Drawing.Color.Indigo;
            this.comboBoxProf.FormattingEnabled = true;
            this.comboBoxProf.Items.AddRange(new object[] {
            "House Wife",
            "Teacher",
            "Student ",
            "Service-Holder"});
            this.comboBoxProf.Location = new System.Drawing.Point(124, 360);
            this.comboBoxProf.Name = "comboBoxProf";
            this.comboBoxProf.Size = new System.Drawing.Size(147, 21);
            this.comboBoxProf.TabIndex = 26;
            // 
            // labelProf
            // 
            this.labelProf.AutoSize = true;
            this.labelProf.BackColor = System.Drawing.Color.Transparent;
            this.labelProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProf.ForeColor = System.Drawing.Color.Indigo;
            this.labelProf.Location = new System.Drawing.Point(22, 359);
            this.labelProf.Name = "labelProf";
            this.labelProf.Size = new System.Drawing.Size(100, 18);
            this.labelProf.TabIndex = 27;
            this.labelProf.Text = "Profession :";
            // 
            // jThinButtonRegistration
            // 
            this.jThinButtonRegistration.BackColor = System.Drawing.Color.Transparent;
            this.jThinButtonRegistration.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.jThinButtonRegistration.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.jThinButtonRegistration.BorderRadius = 5;
            this.jThinButtonRegistration.ButtonText = "Register";
            this.jThinButtonRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jThinButtonRegistration.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonRegistration.Font_Size = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonRegistration.ForeColors = System.Drawing.Color.GhostWhite;
            this.jThinButtonRegistration.HoverBackground = System.Drawing.Color.Indigo;
            this.jThinButtonRegistration.HoverBorder = System.Drawing.Color.Purple;
            this.jThinButtonRegistration.HoverFontColor = System.Drawing.SystemColors.Desktop;
            this.jThinButtonRegistration.LineThickness = 2;
            this.jThinButtonRegistration.Location = new System.Drawing.Point(96, 438);
            this.jThinButtonRegistration.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.jThinButtonRegistration.Name = "jThinButtonRegistration";
            this.jThinButtonRegistration.Size = new System.Drawing.Size(166, 40);
            this.jThinButtonRegistration.TabIndex = 28;
            this.jThinButtonRegistration.Click += new System.EventHandler(this.jThinButtonRegistration_Click);
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogin.LinkColor = System.Drawing.Color.Purple;
            this.linkLabelLogin.Location = new System.Drawing.Point(186, 555);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(137, 13);
            this.linkLabelLogin.TabIndex = 29;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "<< Back to Login Page";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // RegistrationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 589);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.jThinButtonRegistration);
            this.Controls.Add(this.labelProf);
            this.Controls.Add(this.comboBoxProf);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.jMaterialTextboxPin);
            this.Controls.Add(this.jMaterialTextboxNumber);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelPin);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.jMaterialTextboxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelReg);
            this.DoubleBuffered = true;
            this.Name = "RegistrationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingEvent);
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Label labelName;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextboxName;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelGender;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextboxNumber;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextboxPin;
        private System.Windows.Forms.Label labelPin;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.ComboBox comboBoxProf;
        private System.Windows.Forms.Label labelProf;
        private JThinButton.JThinButton jThinButtonRegistration;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
    }
}