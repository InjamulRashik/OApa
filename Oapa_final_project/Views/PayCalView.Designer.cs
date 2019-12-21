namespace Oapa_final_project.Views
{
    partial class PayCalView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayCalView));
            this.richTextBoxPaymentSlip = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelServiceHour = new System.Windows.Forms.Label();
            this.labelCharge = new System.Windows.Forms.Label();
            this.labelServiceCharge = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.jThinButtonConfirm = new JThinButton.JThinButton();
            this.labelDateShow = new System.Windows.Forms.Label();
            this.labelTimeShow = new System.Windows.Forms.Label();
            this.jThinButtonCancel = new JThinButton.JThinButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxPaymentSlip
            // 
            this.richTextBoxPaymentSlip.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxPaymentSlip.Location = new System.Drawing.Point(37, 167);
            this.richTextBoxPaymentSlip.Name = "richTextBoxPaymentSlip";
            this.richTextBoxPaymentSlip.Size = new System.Drawing.Size(270, 292);
            this.richTextBoxPaymentSlip.TabIndex = 0;
            this.richTextBoxPaymentSlip.Text = "";
            this.richTextBoxPaymentSlip.TextChanged += new System.EventHandler(this.richTextBoxPaymentSlip_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Approximate Cost";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.White;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelDate.Location = new System.Drawing.Point(43, 178);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(135, 16);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Appoinment Date :";
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.White;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTime.Location = new System.Drawing.Point(43, 217);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(137, 16);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Appoinment Time :";
            // 
            // labelServiceHour
            // 
            this.labelServiceHour.AutoSize = true;
            this.labelServiceHour.BackColor = System.Drawing.Color.White;
            this.labelServiceHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceHour.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelServiceHour.Location = new System.Drawing.Point(43, 256);
            this.labelServiceHour.Name = "labelServiceHour";
            this.labelServiceHour.Size = new System.Drawing.Size(106, 16);
            this.labelServiceHour.TabIndex = 4;
            this.labelServiceHour.Text = "Service Hour :";
            // 
            // labelCharge
            // 
            this.labelCharge.AutoSize = true;
            this.labelCharge.BackColor = System.Drawing.Color.White;
            this.labelCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharge.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelCharge.Location = new System.Drawing.Point(43, 311);
            this.labelCharge.Name = "labelCharge";
            this.labelCharge.Size = new System.Drawing.Size(98, 16);
            this.labelCharge.TabIndex = 5;
            this.labelCharge.Text = "Hourly Rate: ";
            // 
            // labelServiceCharge
            // 
            this.labelServiceCharge.AutoSize = true;
            this.labelServiceCharge.BackColor = System.Drawing.Color.White;
            this.labelServiceCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceCharge.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelServiceCharge.Location = new System.Drawing.Point(43, 353);
            this.labelServiceCharge.Name = "labelServiceCharge";
            this.labelServiceCharge.Size = new System.Drawing.Size(123, 16);
            this.labelServiceCharge.TabIndex = 6;
            this.labelServiceCharge.Text = "Service Charge :";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.BackColor = System.Drawing.Color.White;
            this.labelTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCost.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTotalCost.Location = new System.Drawing.Point(43, 387);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(87, 16);
            this.labelTotalCost.TabIndex = 7;
            this.labelTotalCost.Text = "Total Cost :";
            // 
            // jThinButtonConfirm
            // 
            this.jThinButtonConfirm.BackColor = System.Drawing.Color.Transparent;
            this.jThinButtonConfirm.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.jThinButtonConfirm.BorderColor = System.Drawing.Color.MediumPurple;
            this.jThinButtonConfirm.BorderRadius = 5;
            this.jThinButtonConfirm.ButtonText = "Confirm";
            this.jThinButtonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jThinButtonConfirm.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonConfirm.Font_Size = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonConfirm.ForeColors = System.Drawing.Color.GhostWhite;
            this.jThinButtonConfirm.HoverBackground = System.Drawing.Color.Indigo;
            this.jThinButtonConfirm.HoverBorder = System.Drawing.Color.Purple;
            this.jThinButtonConfirm.HoverFontColor = System.Drawing.SystemColors.Desktop;
            this.jThinButtonConfirm.LineThickness = 2;
            this.jThinButtonConfirm.Location = new System.Drawing.Point(177, 478);
            this.jThinButtonConfirm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.jThinButtonConfirm.Name = "jThinButtonConfirm";
            this.jThinButtonConfirm.Size = new System.Drawing.Size(80, 38);
            this.jThinButtonConfirm.TabIndex = 29;
            this.jThinButtonConfirm.Click += new System.EventHandler(this.jThinButtonConfirm_Click);
            // 
            // labelDateShow
            // 
            this.labelDateShow.AutoSize = true;
            this.labelDateShow.BackColor = System.Drawing.Color.White;
            this.labelDateShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateShow.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelDateShow.Location = new System.Drawing.Point(174, 178);
            this.labelDateShow.Name = "labelDateShow";
            this.labelDateShow.Size = new System.Drawing.Size(0, 16);
            this.labelDateShow.TabIndex = 30;
            // 
            // labelTimeShow
            // 
            this.labelTimeShow.AutoSize = true;
            this.labelTimeShow.BackColor = System.Drawing.Color.White;
            this.labelTimeShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeShow.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTimeShow.Location = new System.Drawing.Point(174, 217);
            this.labelTimeShow.Name = "labelTimeShow";
            this.labelTimeShow.Size = new System.Drawing.Size(0, 16);
            this.labelTimeShow.TabIndex = 31;
            // 
            // jThinButtonCancel
            // 
            this.jThinButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.jThinButtonCancel.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.jThinButtonCancel.BorderColor = System.Drawing.Color.MediumPurple;
            this.jThinButtonCancel.BorderRadius = 5;
            this.jThinButtonCancel.ButtonText = "Cancel";
            this.jThinButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jThinButtonCancel.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonCancel.Font_Size = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonCancel.ForeColors = System.Drawing.Color.GhostWhite;
            this.jThinButtonCancel.HoverBackground = System.Drawing.Color.Indigo;
            this.jThinButtonCancel.HoverBorder = System.Drawing.Color.Purple;
            this.jThinButtonCancel.HoverFontColor = System.Drawing.SystemColors.Desktop;
            this.jThinButtonCancel.LineThickness = 2;
            this.jThinButtonCancel.Location = new System.Drawing.Point(68, 478);
            this.jThinButtonCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.jThinButtonCancel.Name = "jThinButtonCancel";
            this.jThinButtonCancel.Size = new System.Drawing.Size(81, 38);
            this.jThinButtonCancel.TabIndex = 32;
            this.jThinButtonCancel.Click += new System.EventHandler(this.jThinButtonCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(59, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 18);
            this.label9.TabIndex = 33;
            this.label9.Text = "------------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(59, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "------------------------------------";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.BackColor = System.Drawing.Color.White;
            this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRate.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelRate.Location = new System.Drawing.Point(228, 311);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(28, 16);
            this.labelRate.TabIndex = 35;
            this.labelRate.Text = "----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(238, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "10%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(238, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "1 hr";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.BackColor = System.Drawing.Color.White;
            this.labelTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTc.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTc.Location = new System.Drawing.Point(222, 387);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(28, 16);
            this.labelTc.TabIndex = 38;
            this.labelTc.Text = "----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(257, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Taka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(257, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Taka";
            // 
            // PayCalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 589);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.jThinButtonCancel);
            this.Controls.Add(this.labelTimeShow);
            this.Controls.Add(this.labelDateShow);
            this.Controls.Add(this.jThinButtonConfirm);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.labelServiceCharge);
            this.Controls.Add(this.labelCharge);
            this.Controls.Add(this.labelServiceHour);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxPaymentSlip);
            this.DoubleBuffered = true;
            this.Name = "PayCalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayCalView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PayCalView_FormClosing);
            this.Load += new System.EventHandler(this.PayCalView_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxPaymentSlip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelServiceHour;
        private System.Windows.Forms.Label labelCharge;
        private System.Windows.Forms.Label labelServiceCharge;
        private System.Windows.Forms.Label labelTotalCost;
        private JThinButton.JThinButton jThinButtonConfirm;
        private System.Windows.Forms.Label labelDateShow;
        private System.Windows.Forms.Label labelTimeShow;
        private JThinButton.JThinButton jThinButtonCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}