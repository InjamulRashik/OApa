namespace Oapa_final_project.Views
{
    partial class PaySlipView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaySlipView));
            this.richTextBoxPaymentSlip = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCharge = new System.Windows.Forms.Label();
            this.labelServiceCharge = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.jThinButtonDone = new JThinButton.JThinButton();
            this.labelDateShow = new System.Windows.Forms.Label();
            this.labelTimeShow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.labelHH = new System.Windows.Forms.Label();
            this.labelSS = new System.Windows.Forms.Label();
            this.labelMM = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelTotCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxPaymentSlip
            // 
            this.richTextBoxPaymentSlip.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxPaymentSlip.Location = new System.Drawing.Point(12, 167);
            this.richTextBoxPaymentSlip.Name = "richTextBoxPaymentSlip";
            this.richTextBoxPaymentSlip.Size = new System.Drawing.Size(319, 292);
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
            this.label1.Location = new System.Drawing.Point(81, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment Slip";
            // 
            // labelCharge
            // 
            this.labelCharge.AutoSize = true;
            this.labelCharge.BackColor = System.Drawing.Color.White;
            this.labelCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharge.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelCharge.Location = new System.Drawing.Point(43, 308);
            this.labelCharge.Name = "labelCharge";
            this.labelCharge.Size = new System.Drawing.Size(98, 16);
            this.labelCharge.TabIndex = 5;
            this.labelCharge.Text = "Hourly Rate :";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(53, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "------------------------------------";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // jThinButtonDone
            // 
            this.jThinButtonDone.BackColor = System.Drawing.Color.Transparent;
            this.jThinButtonDone.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.jThinButtonDone.BorderColor = System.Drawing.Color.MediumPurple;
            this.jThinButtonDone.BorderRadius = 5;
            this.jThinButtonDone.ButtonText = "Done";
            this.jThinButtonDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jThinButtonDone.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonDone.Font_Size = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonDone.ForeColors = System.Drawing.Color.GhostWhite;
            this.jThinButtonDone.HoverBackground = System.Drawing.Color.Indigo;
            this.jThinButtonDone.HoverBorder = System.Drawing.Color.Purple;
            this.jThinButtonDone.HoverFontColor = System.Drawing.SystemColors.Desktop;
            this.jThinButtonDone.LineThickness = 2;
            this.jThinButtonDone.Location = new System.Drawing.Point(122, 482);
            this.jThinButtonDone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.jThinButtonDone.Name = "jThinButtonDone";
            this.jThinButtonDone.Size = new System.Drawing.Size(104, 38);
            this.jThinButtonDone.TabIndex = 29;
            this.jThinButtonDone.Click += new System.EventHandler(this.jThinButtonDone_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(115, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = ":";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.BackColor = System.Drawing.Color.White;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelHour.Location = new System.Drawing.Point(58, 235);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(46, 31);
            this.labelHour.TabIndex = 33;
            this.labelHour.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(202, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 31);
            this.label3.TabIndex = 37;
            this.label3.Text = ":";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.BackColor = System.Drawing.Color.White;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelMin.Location = new System.Drawing.Point(145, 235);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(46, 31);
            this.labelMin.TabIndex = 36;
            this.labelMin.Text = "00";
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.BackColor = System.Drawing.Color.White;
            this.labelSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSec.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelSec.Location = new System.Drawing.Point(232, 235);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(46, 31);
            this.labelSec.TabIndex = 38;
            this.labelSec.Text = "00";
            // 
            // labelHH
            // 
            this.labelHH.AutoSize = true;
            this.labelHH.BackColor = System.Drawing.Color.White;
            this.labelHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHH.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelHH.Location = new System.Drawing.Point(53, 195);
            this.labelHH.Name = "labelHH";
            this.labelHH.Size = new System.Drawing.Size(62, 25);
            this.labelHH.TabIndex = 39;
            this.labelHH.Text = "Hour";
            // 
            // labelSS
            // 
            this.labelSS.AutoSize = true;
            this.labelSS.BackColor = System.Drawing.Color.White;
            this.labelSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSS.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelSS.Location = new System.Drawing.Point(215, 195);
            this.labelSS.Name = "labelSS";
            this.labelSS.Size = new System.Drawing.Size(91, 25);
            this.labelSS.TabIndex = 40;
            this.labelSS.Text = "Second";
            // 
            // labelMM
            // 
            this.labelMM.AutoSize = true;
            this.labelMM.BackColor = System.Drawing.Color.White;
            this.labelMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMM.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelMM.Location = new System.Drawing.Point(126, 196);
            this.labelMM.Name = "labelMM";
            this.labelMM.Size = new System.Drawing.Size(83, 25);
            this.labelMM.TabIndex = 41;
            this.labelMM.Text = "Minute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(53, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "------------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(235, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "10%";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.BackColor = System.Drawing.Color.White;
            this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRate.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelRate.Location = new System.Drawing.Point(235, 308);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(0, 16);
            this.labelRate.TabIndex = 44;
            // 
            // labelTotCost
            // 
            this.labelTotCost.AutoSize = true;
            this.labelTotCost.BackColor = System.Drawing.Color.White;
            this.labelTotCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotCost.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTotCost.Location = new System.Drawing.Point(235, 387);
            this.labelTotCost.Name = "labelTotCost";
            this.labelTotCost.Size = new System.Drawing.Size(0, 16);
            this.labelTotCost.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(280, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Taka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(280, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Taka";
            // 
            // PaySlipView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 589);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTotCost);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMM);
            this.Controls.Add(this.labelSS);
            this.Controls.Add(this.labelHH);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelTimeShow);
            this.Controls.Add(this.labelDateShow);
            this.Controls.Add(this.jThinButtonDone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.labelServiceCharge);
            this.Controls.Add(this.labelCharge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxPaymentSlip);
            this.DoubleBuffered = true;
            this.Name = "PaySlipView";
            this.Text = "PayCalView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingClicked);
            this.Load += new System.EventHandler(this.PaySlipView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxPaymentSlip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCharge;
        private System.Windows.Forms.Label labelServiceCharge;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label label9;
        private JThinButton.JThinButton jThinButtonDone;
        private System.Windows.Forms.Label labelDateShow;
        private System.Windows.Forms.Label labelTimeShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label labelHH;
        private System.Windows.Forms.Label labelSS;
        private System.Windows.Forms.Label labelMM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelTotCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}