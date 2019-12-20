namespace Oapa_final_project.Views
{
    partial class UserHireHistoryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHireHistoryView));
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jThinButtonShowUsers = new JThinButton.JThinButton();
            this.labelWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogin.LinkColor = System.Drawing.Color.Purple;
            this.linkLabelLogin.Location = new System.Drawing.Point(188, 571);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(151, 13);
            this.linkLabelLogin.TabIndex = 41;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "<< Back to Landing Page";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 222);
            this.dataGridView1.TabIndex = 40;
            // 
            // jThinButtonShowUsers
            // 
            this.jThinButtonShowUsers.BackColor = System.Drawing.Color.Transparent;
            this.jThinButtonShowUsers.BackgroundColor = System.Drawing.Color.MediumOrchid;
            this.jThinButtonShowUsers.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.jThinButtonShowUsers.BorderRadius = 5;
            this.jThinButtonShowUsers.ButtonText = "Users";
            this.jThinButtonShowUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jThinButtonShowUsers.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonShowUsers.Font_Size = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonShowUsers.ForeColors = System.Drawing.Color.GhostWhite;
            this.jThinButtonShowUsers.HoverBackground = System.Drawing.Color.Indigo;
            this.jThinButtonShowUsers.HoverBorder = System.Drawing.Color.Purple;
            this.jThinButtonShowUsers.HoverFontColor = System.Drawing.SystemColors.Desktop;
            this.jThinButtonShowUsers.LineThickness = 2;
            this.jThinButtonShowUsers.Location = new System.Drawing.Point(30, 213);
            this.jThinButtonShowUsers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.jThinButtonShowUsers.Name = "jThinButtonShowUsers";
            this.jThinButtonShowUsers.Size = new System.Drawing.Size(97, 40);
            this.jThinButtonShowUsers.TabIndex = 39;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Quicksand Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(57, 112);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(234, 40);
            this.labelWelcome.TabIndex = 38;
            this.labelWelcome.Text = "Hire History ";
            // 
            // UserHireHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 589);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.jThinButtonShowUsers);
            this.Controls.Add(this.labelWelcome);
            this.DoubleBuffered = true;
            this.Name = "UserHireHistoryView";
            this.Text = "UserHireHistoryView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private JThinButton.JThinButton jThinButtonShowUsers;
        private System.Windows.Forms.Label labelWelcome;
    }
}