namespace Oapa_final_project.Views
{
    partial class MaidView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaidView));
            this.ComboBoxBaby = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMaidName = new System.Windows.Forms.Label();
            this.labelMaidRate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jThinButtonShowSelect = new JThinButton.JThinButton();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ComboBoxBaby
            // 
            this.ComboBoxBaby.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxBaby.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.ComboBoxBaby.FormattingEnabled = true;
            this.ComboBoxBaby.Location = new System.Drawing.Point(58, 200);
            this.ComboBoxBaby.Name = "ComboBoxBaby";
            this.ComboBoxBaby.Size = new System.Drawing.Size(218, 26);
            this.ComboBoxBaby.TabIndex = 0;
            this.ComboBoxBaby.Text = "Select Maid";
            this.ComboBoxBaby.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMaid_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(44, 258);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(246, 98);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(56, 275);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(214, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rate :";
            // 
            // labelMaidName
            // 
            this.labelMaidName.AutoSize = true;
            this.labelMaidName.BackColor = System.Drawing.Color.Transparent;
            this.labelMaidName.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaidName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelMaidName.Location = new System.Drawing.Point(56, 305);
            this.labelMaidName.Name = "labelMaidName";
            this.labelMaidName.Size = new System.Drawing.Size(48, 18);
            this.labelMaidName.TabIndex = 4;
            this.labelMaidName.Text = "..........";
            this.labelMaidName.Click += new System.EventHandler(this.labelMaidName_Click);
            // 
            // labelMaidRate
            // 
            this.labelMaidRate.AutoSize = true;
            this.labelMaidRate.BackColor = System.Drawing.Color.Transparent;
            this.labelMaidRate.Font = new System.Drawing.Font("Quicksand Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaidRate.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelMaidRate.Location = new System.Drawing.Point(214, 305);
            this.labelMaidRate.Name = "labelMaidRate";
            this.labelMaidRate.Size = new System.Drawing.Size(48, 18);
            this.labelMaidRate.TabIndex = 5;
            this.labelMaidRate.Text = "..........";
            this.labelMaidRate.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Quicksand Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(72, 141);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(190, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maid Selection";
            // 
            // jThinButtonShowSelect
            // 
            this.jThinButtonShowSelect.BackColor = System.Drawing.Color.Transparent;
            this.jThinButtonShowSelect.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.jThinButtonShowSelect.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.jThinButtonShowSelect.BorderRadius = 5;
            this.jThinButtonShowSelect.ButtonText = "Select";
            this.jThinButtonShowSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jThinButtonShowSelect.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonShowSelect.Font_Size = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonShowSelect.ForeColors = System.Drawing.Color.GhostWhite;
            this.jThinButtonShowSelect.HoverBackground = System.Drawing.Color.Indigo;
            this.jThinButtonShowSelect.HoverBorder = System.Drawing.Color.Purple;
            this.jThinButtonShowSelect.HoverFontColor = System.Drawing.SystemColors.Desktop;
            this.jThinButtonShowSelect.LineThickness = 2;
            this.jThinButtonShowSelect.Location = new System.Drawing.Point(119, 388);
            this.jThinButtonShowSelect.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.jThinButtonShowSelect.Name = "jThinButtonShowSelect";
            this.jThinButtonShowSelect.Size = new System.Drawing.Size(97, 40);
            this.jThinButtonShowSelect.TabIndex = 35;
            this.jThinButtonShowSelect.Click += new System.EventHandler(this.jThinButtonShowSelect_Click);
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogin.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.linkLabelLogin.Location = new System.Drawing.Point(193, 567);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(138, 13);
            this.linkLabelLogin.TabIndex = 38;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "<< Back to Home Page";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // MaidView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 589);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.jThinButtonShowSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMaidRate);
            this.Controls.Add(this.labelMaidName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ComboBoxBaby);
            this.DoubleBuffered = true;
            this.Name = "MaidView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaidView";
            this.Load += new System.EventHandler(this.MaidView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxBaby;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMaidName;
        private System.Windows.Forms.Label labelMaidRate;
        private System.Windows.Forms.Label label3;
        private JThinButton.JThinButton jThinButtonShowSelect;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
    }
}