namespace Checkr.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.chkrLogo = new System.Windows.Forms.PictureBox();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.cpDeveloper = new MetroFramework.Controls.MetroLink();
            this.cpOpenSource = new MetroFramework.Controls.MetroLink();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chkrLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // chkrLogo
            // 
            this.chkrLogo.Image = ((System.Drawing.Image)(resources.GetObject("chkrLogo.Image")));
            this.chkrLogo.Location = new System.Drawing.Point(85, 72);
            this.chkrLogo.Name = "chkrLogo";
            this.chkrLogo.Size = new System.Drawing.Size(128, 128);
            this.chkrLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chkrLogo.TabIndex = 0;
            this.chkrLogo.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(23, 224);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(68, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(23, 257);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(97, 223);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(171, 23);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(97, 254);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(171, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // cpDeveloper
            // 
            this.cpDeveloper.Location = new System.Drawing.Point(43, 323);
            this.cpDeveloper.Name = "cpDeveloper";
            this.cpDeveloper.Size = new System.Drawing.Size(213, 23);
            this.cpDeveloper.TabIndex = 5;
            this.cpDeveloper.Text = "Developed by Prashant M. Shrestha.";
            // 
            // cpOpenSource
            // 
            this.cpOpenSource.Location = new System.Drawing.Point(43, 344);
            this.cpOpenSource.Name = "cpOpenSource";
            this.cpOpenSource.Size = new System.Drawing.Size(213, 23);
            this.cpOpenSource.TabIndex = 6;
            this.cpOpenSource.Text = "Copyright © 2015";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(97, 283);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(171, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 388);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cpOpenSource);
            this.Controls.Add(this.cpDeveloper);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.chkrLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.Resizable = false;
            this.Text = "Checkr Login";
            ((System.ComponentModel.ISupportInitialize)(this.chkrLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox chkrLogo;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLink cpDeveloper;
        private MetroFramework.Controls.MetroLink cpOpenSource;
        private MetroFramework.Controls.MetroButton btnLogin;
    }
}