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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.jThinButtonQR = new JThinButton.JThinButton();
            this.labelDateShow = new System.Windows.Forms.Label();
            this.labelTimeShow = new System.Windows.Forms.Label();
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
            this.label1.Font = new System.Drawing.Font("Quicksand", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Approximate Cost";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.White;
            this.labelDate.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelDate.Location = new System.Drawing.Point(43, 178);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(125, 18);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Appoinment Date :";
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.White;
            this.labelTime.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTime.Location = new System.Drawing.Point(43, 217);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(125, 18);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Appoinment Time :";
            // 
            // labelServiceHour
            // 
            this.labelServiceHour.AutoSize = true;
            this.labelServiceHour.BackColor = System.Drawing.Color.White;
            this.labelServiceHour.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceHour.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelServiceHour.Location = new System.Drawing.Point(43, 256);
            this.labelServiceHour.Name = "labelServiceHour";
            this.labelServiceHour.Size = new System.Drawing.Size(94, 18);
            this.labelServiceHour.TabIndex = 4;
            this.labelServiceHour.Text = "Service Hour :";
            // 
            // labelCharge
            // 
            this.labelCharge.AutoSize = true;
            this.labelCharge.BackColor = System.Drawing.Color.White;
            this.labelCharge.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharge.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelCharge.Location = new System.Drawing.Point(43, 313);
            this.labelCharge.Name = "labelCharge";
            this.labelCharge.Size = new System.Drawing.Size(59, 18);
            this.labelCharge.TabIndex = 5;
            this.labelCharge.Text = "Charge :";
            // 
            // labelServiceCharge
            // 
            this.labelServiceCharge.AutoSize = true;
            this.labelServiceCharge.BackColor = System.Drawing.Color.White;
            this.labelServiceCharge.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceCharge.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelServiceCharge.Location = new System.Drawing.Point(43, 353);
            this.labelServiceCharge.Name = "labelServiceCharge";
            this.labelServiceCharge.Size = new System.Drawing.Size(106, 18);
            this.labelServiceCharge.TabIndex = 6;
            this.labelServiceCharge.Text = "Service Charge :";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.BackColor = System.Drawing.Color.White;
            this.labelTotalCost.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCost.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTotalCost.Location = new System.Drawing.Point(43, 387);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(77, 18);
            this.labelTotalCost.TabIndex = 7;
            this.labelTotalCost.Text = "Total Cost :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Bauhaus 93", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(53, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "---------------------------------------------------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Bauhaus 93", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(53, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "---------------------------------------------------------";
            // 
            // jThinButtonQR
            // 
            this.jThinButtonQR.BackColor = System.Drawing.Color.Transparent;
            this.jThinButtonQR.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.jThinButtonQR.BorderColor = System.Drawing.Color.MediumPurple;
            this.jThinButtonQR.BorderRadius = 5;
            this.jThinButtonQR.ButtonText = "QR Scan";
            this.jThinButtonQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jThinButtonQR.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonQR.Font_Size = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonQR.ForeColors = System.Drawing.Color.GhostWhite;
            this.jThinButtonQR.HoverBackground = System.Drawing.Color.Indigo;
            this.jThinButtonQR.HoverBorder = System.Drawing.Color.Purple;
            this.jThinButtonQR.HoverFontColor = System.Drawing.SystemColors.Desktop;
            this.jThinButtonQR.LineThickness = 2;
            this.jThinButtonQR.Location = new System.Drawing.Point(111, 478);
            this.jThinButtonQR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.jThinButtonQR.Name = "jThinButtonQR";
            this.jThinButtonQR.Size = new System.Drawing.Size(128, 38);
            this.jThinButtonQR.TabIndex = 29;
            // 
            // labelDateShow
            // 
            this.labelDateShow.AutoSize = true;
            this.labelDateShow.BackColor = System.Drawing.Color.White;
            this.labelDateShow.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateShow.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelDateShow.Location = new System.Drawing.Point(174, 178);
            this.labelDateShow.Name = "labelDateShow";
            this.labelDateShow.Size = new System.Drawing.Size(0, 18);
            this.labelDateShow.TabIndex = 30;
            // 
            // labelTimeShow
            // 
            this.labelTimeShow.AutoSize = true;
            this.labelTimeShow.BackColor = System.Drawing.Color.White;
            this.labelTimeShow.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeShow.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTimeShow.Location = new System.Drawing.Point(174, 217);
            this.labelTimeShow.Name = "labelTimeShow";
            this.labelTimeShow.Size = new System.Drawing.Size(0, 18);
            this.labelTimeShow.TabIndex = 31;
            // 
            // PayCalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 589);
            this.Controls.Add(this.labelTimeShow);
            this.Controls.Add(this.labelDateShow);
            this.Controls.Add(this.jThinButtonQR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
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
            this.Text = "PayCalView";
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private JThinButton.JThinButton jThinButtonQR;
        private System.Windows.Forms.Label labelDateShow;
        private System.Windows.Forms.Label labelTimeShow;
    }
}