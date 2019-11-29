﻿namespace Oapa_final_project
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMaid = new System.Windows.Forms.Label();
            this.labelBaby = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.circularButtonBaby = new Oapa_final_project.CircularButton();
            this.circularButtonMaid = new Oapa_final_project.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(126, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(120, 189);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(102, 28);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome,";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(111, 219);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(120, 24);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Sirazum Meem";
            // 
            // labelMaid
            // 
            this.labelMaid.AutoSize = true;
            this.labelMaid.BackColor = System.Drawing.Color.Transparent;
            this.labelMaid.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaid.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelMaid.Location = new System.Drawing.Point(59, 501);
            this.labelMaid.Name = "labelMaid";
            this.labelMaid.Size = new System.Drawing.Size(47, 24);
            this.labelMaid.TabIndex = 5;
            this.labelMaid.Text = "Maid";
            // 
            // labelBaby
            // 
            this.labelBaby.AutoSize = true;
            this.labelBaby.BackColor = System.Drawing.Color.Transparent;
            this.labelBaby.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaby.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelBaby.Location = new System.Drawing.Point(197, 501);
            this.labelBaby.Name = "labelBaby";
            this.labelBaby.Size = new System.Drawing.Size(97, 24);
            this.labelBaby.TabIndex = 6;
            this.labelBaby.Text = "Baby Sitter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(82, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose Your Service";
            // 
            // circularButtonBaby
            // 
            this.circularButtonBaby.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.circularButtonBaby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circularButtonBaby.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circularButtonBaby.FlatAppearance.BorderSize = 0;
            this.circularButtonBaby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonBaby.ForeColor = System.Drawing.Color.White;
            this.circularButtonBaby.Image = ((System.Drawing.Image)(resources.GetObject("circularButtonBaby.Image")));
            this.circularButtonBaby.Location = new System.Drawing.Point(207, 406);
            this.circularButtonBaby.Name = "circularButtonBaby";
            this.circularButtonBaby.Size = new System.Drawing.Size(77, 77);
            this.circularButtonBaby.TabIndex = 4;
            this.circularButtonBaby.UseVisualStyleBackColor = false;
            // 
            // circularButtonMaid
            // 
            this.circularButtonMaid.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.circularButtonMaid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circularButtonMaid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circularButtonMaid.FlatAppearance.BorderSize = 0;
            this.circularButtonMaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonMaid.ForeColor = System.Drawing.Color.White;
            this.circularButtonMaid.Image = ((System.Drawing.Image)(resources.GetObject("circularButtonMaid.Image")));
            this.circularButtonMaid.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.circularButtonMaid.Location = new System.Drawing.Point(44, 406);
            this.circularButtonMaid.Name = "circularButtonMaid";
            this.circularButtonMaid.Size = new System.Drawing.Size(77, 77);
            this.circularButtonMaid.TabIndex = 3;
            this.circularButtonMaid.UseVisualStyleBackColor = false;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBaby);
            this.Controls.Add(this.labelMaid);
            this.Controls.Add(this.circularButtonBaby);
            this.Controls.Add(this.circularButtonMaid);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LandingPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingEvent);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelName;
        private CircularButton circularButtonMaid;
        private CircularButton circularButtonBaby;
        private System.Windows.Forms.Label labelMaid;
        private System.Windows.Forms.Label labelBaby;
        private System.Windows.Forms.Label label1;
    }
}