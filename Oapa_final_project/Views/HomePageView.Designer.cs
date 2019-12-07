namespace Oapa_final_project.Views
{
    partial class HomePageView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageView));
            this.labelAdmin = new System.Windows.Forms.Label();
            this.circularButtonAdmin = new Oapa_final_project.CircularButton();
            this.labelUser = new System.Windows.Forms.Label();
            this.circularButtonUser = new Oapa_final_project.CircularButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelAdmin.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelAdmin.Location = new System.Drawing.Point(45, 467);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(59, 24);
            this.labelAdmin.TabIndex = 7;
            this.labelAdmin.Text = "Admin";
            // 
            // circularButtonAdmin
            // 
            this.circularButtonAdmin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.circularButtonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circularButtonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circularButtonAdmin.FlatAppearance.BorderSize = 0;
            this.circularButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonAdmin.ForeColor = System.Drawing.Color.White;
            this.circularButtonAdmin.Image = ((System.Drawing.Image)(resources.GetObject("circularButtonAdmin.Image")));
            this.circularButtonAdmin.Location = new System.Drawing.Point(38, 373);
            this.circularButtonAdmin.Name = "circularButtonAdmin";
            this.circularButtonAdmin.Size = new System.Drawing.Size(77, 77);
            this.circularButtonAdmin.TabIndex = 6;
            this.circularButtonAdmin.UseVisualStyleBackColor = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelUser.Location = new System.Drawing.Point(256, 467);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(45, 24);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "User";
            // 
            // circularButtonUser
            // 
            this.circularButtonUser.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.circularButtonUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circularButtonUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circularButtonUser.FlatAppearance.BorderSize = 0;
            this.circularButtonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButtonUser.ForeColor = System.Drawing.Color.White;
            this.circularButtonUser.Image = ((System.Drawing.Image)(resources.GetObject("circularButtonUser.Image")));
            this.circularButtonUser.Location = new System.Drawing.Point(234, 373);
            this.circularButtonUser.Name = "circularButtonUser";
            this.circularButtonUser.Size = new System.Drawing.Size(77, 77);
            this.circularButtonUser.TabIndex = 8;
            this.circularButtonUser.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(30, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome To OAPA!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(114, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Login As :";
            // 
            // HomePageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 589);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.circularButtonUser);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.circularButtonAdmin);
            this.DoubleBuffered = true;
            this.Name = "HomePageView";
            this.Text = "HomePageView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdmin;
        private CircularButton circularButtonAdmin;
        private System.Windows.Forms.Label labelUser;
        private CircularButton circularButtonUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}