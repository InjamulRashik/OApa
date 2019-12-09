namespace Oapa_final_project.Views

{
    partial class QRView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRView));
            this.labelMin = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.labelCs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMM = new System.Windows.Forms.Label();
            this.labelSS = new System.Windows.Forms.Label();
            this.labelHH = new System.Windows.Forms.Label();
            this.jThinButtonStart = new JThinButton.JThinButton();
            this.jThinButtonStop = new JThinButton.JThinButton();
            this.jThinButtonDone = new JThinButton.JThinButton();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.BackColor = System.Drawing.Color.Transparent;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.ForeColor = System.Drawing.Color.White;
            this.labelMin.Location = new System.Drawing.Point(136, 160);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(62, 42);
            this.labelMin.TabIndex = 3;
            this.labelMin.Text = "00";
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.BackColor = System.Drawing.Color.Transparent;
            this.labelSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSec.ForeColor = System.Drawing.Color.White;
            this.labelSec.Location = new System.Drawing.Point(240, 160);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(62, 42);
            this.labelSec.TabIndex = 6;
            this.labelSec.Text = "00";
            // 
            // labelCs
            // 
            this.labelCs.AutoSize = true;
            this.labelCs.BackColor = System.Drawing.Color.Transparent;
            this.labelCs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCs.ForeColor = System.Drawing.Color.White;
            this.labelCs.Location = new System.Drawing.Point(307, 182);
            this.labelCs.Name = "labelCs";
            this.labelCs.Size = new System.Drawing.Size(29, 20);
            this.labelCs.TabIndex = 7;
            this.labelCs.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(206, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(301, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 42);
            this.label4.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "00";
            // 
            // labelMM
            // 
            this.labelMM.AutoSize = true;
            this.labelMM.BackColor = System.Drawing.Color.Transparent;
            this.labelMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMM.ForeColor = System.Drawing.Color.Transparent;
            this.labelMM.Location = new System.Drawing.Point(128, 140);
            this.labelMM.Name = "labelMM";
            this.labelMM.Size = new System.Drawing.Size(83, 25);
            this.labelMM.TabIndex = 44;
            this.labelMM.Text = "Minute";
            // 
            // labelSS
            // 
            this.labelSS.AutoSize = true;
            this.labelSS.BackColor = System.Drawing.Color.Transparent;
            this.labelSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSS.ForeColor = System.Drawing.Color.White;
            this.labelSS.Location = new System.Drawing.Point(229, 140);
            this.labelSS.Name = "labelSS";
            this.labelSS.Size = new System.Drawing.Size(91, 25);
            this.labelSS.TabIndex = 43;
            this.labelSS.Text = "Second";
            // 
            // labelHH
            // 
            this.labelHH.AutoSize = true;
            this.labelHH.BackColor = System.Drawing.Color.Transparent;
            this.labelHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHH.ForeColor = System.Drawing.Color.White;
            this.labelHH.Location = new System.Drawing.Point(41, 140);
            this.labelHH.Name = "labelHH";
            this.labelHH.Size = new System.Drawing.Size(62, 25);
            this.labelHH.TabIndex = 42;
            this.labelHH.Text = "Hour";
            // 
            // jThinButtonStart
            // 
            this.jThinButtonStart.BackColor = System.Drawing.Color.Transparent;
            this.jThinButtonStart.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.jThinButtonStart.BorderColor = System.Drawing.Color.MediumPurple;
            this.jThinButtonStart.BorderRadius = 5;
            this.jThinButtonStart.ButtonText = "Start";
            this.jThinButtonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jThinButtonStart.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonStart.Font_Size = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonStart.ForeColors = System.Drawing.Color.GhostWhite;
            this.jThinButtonStart.HoverBackground = System.Drawing.Color.Indigo;
            this.jThinButtonStart.HoverBorder = System.Drawing.Color.Purple;
            this.jThinButtonStart.HoverFontColor = System.Drawing.SystemColors.Desktop;
            this.jThinButtonStart.LineThickness = 2;
            this.jThinButtonStart.Location = new System.Drawing.Point(56, 497);
            this.jThinButtonStart.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.jThinButtonStart.Name = "jThinButtonStart";
            this.jThinButtonStart.Size = new System.Drawing.Size(80, 38);
            this.jThinButtonStart.TabIndex = 45;
            this.jThinButtonStart.Click += new System.EventHandler(this.jThinButtonStart_Click);
            // 
            // jThinButtonStop
            // 
            this.jThinButtonStop.BackColor = System.Drawing.Color.Transparent;
            this.jThinButtonStop.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.jThinButtonStop.BorderColor = System.Drawing.Color.MediumPurple;
            this.jThinButtonStop.BorderRadius = 5;
            this.jThinButtonStop.ButtonText = "Stop";
            this.jThinButtonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jThinButtonStop.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonStop.Font_Size = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonStop.ForeColors = System.Drawing.Color.GhostWhite;
            this.jThinButtonStop.HoverBackground = System.Drawing.Color.Indigo;
            this.jThinButtonStop.HoverBorder = System.Drawing.Color.Purple;
            this.jThinButtonStop.HoverFontColor = System.Drawing.SystemColors.Desktop;
            this.jThinButtonStop.LineThickness = 2;
            this.jThinButtonStop.Location = new System.Drawing.Point(206, 497);
            this.jThinButtonStop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.jThinButtonStop.Name = "jThinButtonStop";
            this.jThinButtonStop.Size = new System.Drawing.Size(80, 38);
            this.jThinButtonStop.TabIndex = 46;
            this.jThinButtonStop.Click += new System.EventHandler(this.jThinButtonStop_Click);
            // 
            // jThinButtonDone
            // 
            this.jThinButtonDone.BackColor = System.Drawing.Color.Transparent;
            this.jThinButtonDone.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.jThinButtonDone.BorderColor = System.Drawing.Color.MediumPurple;
            this.jThinButtonDone.BorderRadius = 5;
            this.jThinButtonDone.ButtonText = "Done";
            this.jThinButtonDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jThinButtonDone.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonDone.Font_Size = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonDone.ForeColors = System.Drawing.Color.GhostWhite;
            this.jThinButtonDone.HoverBackground = System.Drawing.Color.Indigo;
            this.jThinButtonDone.HoverBorder = System.Drawing.Color.Purple;
            this.jThinButtonDone.HoverFontColor = System.Drawing.SystemColors.Desktop;
            this.jThinButtonDone.LineThickness = 2;
            this.jThinButtonDone.Location = new System.Drawing.Point(262, 599);
            this.jThinButtonDone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.jThinButtonDone.Name = "jThinButtonDone";
            this.jThinButtonDone.Size = new System.Drawing.Size(80, 38);
            this.jThinButtonDone.TabIndex = 47;
            this.jThinButtonDone.Click += new System.EventHandler(this.jThinButtonDone_Click);
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxQR.BackgroundImage")));
            this.pictureBoxQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxQR.Location = new System.Drawing.Point(61, 241);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(227, 227);
            this.pictureBoxQR.TabIndex = 49;
            this.pictureBoxQR.TabStop = false;
            // 
            // QRView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(353, 650);
            this.Controls.Add(this.pictureBoxQR);
            this.Controls.Add(this.jThinButtonDone);
            this.Controls.Add(this.jThinButtonStop);
            this.Controls.Add(this.jThinButtonStart);
            this.Controls.Add(this.labelMM);
            this.Controls.Add(this.labelSS);
            this.Controls.Add(this.labelHH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCs);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.labelMin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QRView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Timer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label labelCs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMM;
        private System.Windows.Forms.Label labelSS;
        private System.Windows.Forms.Label labelHH;
        private JThinButton.JThinButton jThinButtonStart;
        private JThinButton.JThinButton jThinButtonStop;
        private JThinButton.JThinButton jThinButtonDone;
        private System.Windows.Forms.PictureBox pictureBoxQR;
    }
}

