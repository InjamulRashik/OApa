namespace Oapa_final_project.Views
{
    partial class AdminLoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginView));
            this.jThinButtonAdminLogin = new JThinButton.JThinButton();
            this.jMetroTextBoxAdminPassword = new JMetroTextBox.JMetroTextBox();
            this.jMetroTextBoxAdminId = new JMetroTextBox.JMetroTextBox();
            this.labelPinLog = new System.Windows.Forms.Label();
            this.labelNumberLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jThinButtonAdminLogin
            // 
            this.jThinButtonAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.jThinButtonAdminLogin.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.jThinButtonAdminLogin.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.jThinButtonAdminLogin.BorderRadius = 5;
            this.jThinButtonAdminLogin.ButtonText = "Login";
            this.jThinButtonAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jThinButtonAdminLogin.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonAdminLogin.Font_Size = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButtonAdminLogin.ForeColors = System.Drawing.Color.GhostWhite;
            this.jThinButtonAdminLogin.HoverBackground = System.Drawing.Color.Indigo;
            this.jThinButtonAdminLogin.HoverBorder = System.Drawing.Color.Purple;
            this.jThinButtonAdminLogin.HoverFontColor = System.Drawing.SystemColors.Desktop;
            this.jThinButtonAdminLogin.LineThickness = 2;
            this.jThinButtonAdminLogin.Location = new System.Drawing.Point(112, 393);
            this.jThinButtonAdminLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.jThinButtonAdminLogin.Name = "jThinButtonAdminLogin";
            this.jThinButtonAdminLogin.Size = new System.Drawing.Size(119, 40);
            this.jThinButtonAdminLogin.TabIndex = 24;
            this.jThinButtonAdminLogin.Click += new System.EventHandler(this.jThinButtonAdminLogin_Click);
            // 
            // jMetroTextBoxAdminPassword
            // 
            this.jMetroTextBoxAdminPassword.BackColor = System.Drawing.Color.Transparent;
            this.jMetroTextBoxAdminPassword.BorderColor = System.Drawing.Color.Indigo;
            this.jMetroTextBoxAdminPassword.BorderRadius = 10;
            this.jMetroTextBoxAdminPassword.FillColor = System.Drawing.SystemColors.Control;
            this.jMetroTextBoxAdminPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMetroTextBoxAdminPassword.Font_Size = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMetroTextBoxAdminPassword.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.jMetroTextBoxAdminPassword.IsPassword = true;
            this.jMetroTextBoxAdminPassword.LineThickness = 2;
            this.jMetroTextBoxAdminPassword.Location = new System.Drawing.Point(83, 315);
            this.jMetroTextBoxAdminPassword.Margin = new System.Windows.Forms.Padding(5);
            this.jMetroTextBoxAdminPassword.MaxLength = 32767;
            this.jMetroTextBoxAdminPassword.MouseOnHover = System.Drawing.Color.Purple;
            this.jMetroTextBoxAdminPassword.Name = "jMetroTextBoxAdminPassword";
            this.jMetroTextBoxAdminPassword.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.jMetroTextBoxAdminPassword.OnFocusColor = System.Drawing.Color.Purple;
            this.jMetroTextBoxAdminPassword.OnFocusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.jMetroTextBoxAdminPassword.ReadOnly = false;
            this.jMetroTextBoxAdminPassword.Size = new System.Drawing.Size(177, 37);
            this.jMetroTextBoxAdminPassword.TabIndex = 23;
            this.jMetroTextBoxAdminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jMetroTextBoxAdminPassword.TextName = "";
            // 
            // jMetroTextBoxAdminId
            // 
            this.jMetroTextBoxAdminId.BackColor = System.Drawing.Color.Transparent;
            this.jMetroTextBoxAdminId.BorderColor = System.Drawing.Color.Indigo;
            this.jMetroTextBoxAdminId.BorderRadius = 10;
            this.jMetroTextBoxAdminId.FillColor = System.Drawing.SystemColors.Control;
            this.jMetroTextBoxAdminId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMetroTextBoxAdminId.Font_Size = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMetroTextBoxAdminId.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.jMetroTextBoxAdminId.IsPassword = false;
            this.jMetroTextBoxAdminId.LineThickness = 2;
            this.jMetroTextBoxAdminId.Location = new System.Drawing.Point(83, 206);
            this.jMetroTextBoxAdminId.Margin = new System.Windows.Forms.Padding(5);
            this.jMetroTextBoxAdminId.MaxLength = 32767;
            this.jMetroTextBoxAdminId.MouseOnHover = System.Drawing.Color.Purple;
            this.jMetroTextBoxAdminId.Name = "jMetroTextBoxAdminId";
            this.jMetroTextBoxAdminId.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.jMetroTextBoxAdminId.OnFocusColor = System.Drawing.Color.Purple;
            this.jMetroTextBoxAdminId.OnFocusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.jMetroTextBoxAdminId.ReadOnly = false;
            this.jMetroTextBoxAdminId.Size = new System.Drawing.Size(177, 37);
            this.jMetroTextBoxAdminId.TabIndex = 22;
            this.jMetroTextBoxAdminId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jMetroTextBoxAdminId.TextName = "";
            // 
            // labelPinLog
            // 
            this.labelPinLog.AutoSize = true;
            this.labelPinLog.BackColor = System.Drawing.Color.Transparent;
            this.labelPinLog.Font = new System.Drawing.Font("Quicksand Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPinLog.ForeColor = System.Drawing.Color.Purple;
            this.labelPinLog.Location = new System.Drawing.Point(63, 265);
            this.labelPinLog.Name = "labelPinLog";
            this.labelPinLog.Size = new System.Drawing.Size(223, 22);
            this.labelPinLog.TabIndex = 21;
            this.labelPinLog.Text = "Enter Admin Password";
            // 
            // labelNumberLog
            // 
            this.labelNumberLog.AutoSize = true;
            this.labelNumberLog.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberLog.Font = new System.Drawing.Font("Quicksand Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberLog.ForeColor = System.Drawing.Color.Purple;
            this.labelNumberLog.Location = new System.Drawing.Point(94, 157);
            this.labelNumberLog.Name = "labelNumberLog";
            this.labelNumberLog.Size = new System.Drawing.Size(153, 22);
            this.labelNumberLog.TabIndex = 20;
            this.labelNumberLog.Text = "Enter Admin ID";
            // 
            // AdminLoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 589);
            this.Controls.Add(this.jThinButtonAdminLogin);
            this.Controls.Add(this.jMetroTextBoxAdminPassword);
            this.Controls.Add(this.jMetroTextBoxAdminId);
            this.Controls.Add(this.labelPinLog);
            this.Controls.Add(this.labelNumberLog);
            this.DoubleBuffered = true;
            this.Name = "AdminLoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLoginView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminLoginView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JThinButton.JThinButton jThinButtonAdminLogin;
        private JMetroTextBox.JMetroTextBox jMetroTextBoxAdminPassword;
        private JMetroTextBox.JMetroTextBox jMetroTextBoxAdminId;
        private System.Windows.Forms.Label labelPinLog;
        private System.Windows.Forms.Label labelNumberLog;
    }
}