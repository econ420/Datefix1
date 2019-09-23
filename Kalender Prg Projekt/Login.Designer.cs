namespace Kalender_Prg_Projekt
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernameLabel1 = new System.Windows.Forms.Label();
            this.usernameTextbox1 = new System.Windows.Forms.TextBox();
            this.signInButton1 = new System.Windows.Forms.Button();
            this.passwordLabel1 = new System.Windows.Forms.Label();
            this.passwordTextbox1 = new System.Windows.Forms.TextBox();
            this.signUpLinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // usernameLabel1
            // 
            this.usernameLabel1.AutoSize = true;
            this.usernameLabel1.Location = new System.Drawing.Point(32, 32);
            this.usernameLabel1.Name = "usernameLabel1";
            this.usernameLabel1.Size = new System.Drawing.Size(75, 13);
            this.usernameLabel1.TabIndex = 0;
            this.usernameLabel1.Text = "Benutzername";
            // 
            // usernameTextbox1
            // 
            this.usernameTextbox1.Location = new System.Drawing.Point(139, 29);
            this.usernameTextbox1.Name = "usernameTextbox1";
            this.usernameTextbox1.Size = new System.Drawing.Size(100, 20);
            this.usernameTextbox1.TabIndex = 2;
            // 
            // signInButton1
            // 
            this.signInButton1.Location = new System.Drawing.Point(35, 93);
            this.signInButton1.Name = "signInButton1";
            this.signInButton1.Size = new System.Drawing.Size(204, 23);
            this.signInButton1.TabIndex = 4;
            this.signInButton1.Text = "Anmelden";
            this.signInButton1.UseVisualStyleBackColor = true;
            this.signInButton1.Click += new System.EventHandler(this.signInButton1_Click);
            // 
            // passwordLabel1
            // 
            this.passwordLabel1.AutoSize = true;
            this.passwordLabel1.Location = new System.Drawing.Point(32, 60);
            this.passwordLabel1.Name = "passwordLabel1";
            this.passwordLabel1.Size = new System.Drawing.Size(50, 13);
            this.passwordLabel1.TabIndex = 1;
            this.passwordLabel1.Text = "Passwort";
            // 
            // passwordTextbox1
            // 
            this.passwordTextbox1.Location = new System.Drawing.Point(139, 57);
            this.passwordTextbox1.Name = "passwordTextbox1";
            this.passwordTextbox1.Size = new System.Drawing.Size(100, 20);
            this.passwordTextbox1.TabIndex = 3;
            this.passwordTextbox1.UseSystemPasswordChar = true;
            // 
            // signUpLinkLabel1
            // 
            this.signUpLinkLabel1.AutoSize = true;
            this.signUpLinkLabel1.Location = new System.Drawing.Point(32, 128);
            this.signUpLinkLabel1.Name = "signUpLinkLabel1";
            this.signUpLinkLabel1.Size = new System.Drawing.Size(94, 13);
            this.signUpLinkLabel1.TabIndex = 5;
            this.signUpLinkLabel1.TabStop = true;
            this.signUpLinkLabel1.Text = "Jetzt Registrieren?";
            this.signUpLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLinkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 199);
            this.Controls.Add(this.signUpLinkLabel1);
            this.Controls.Add(this.signInButton1);
            this.Controls.Add(this.passwordTextbox1);
            this.Controls.Add(this.usernameTextbox1);
            this.Controls.Add(this.passwordLabel1);
            this.Controls.Add(this.usernameLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel1;
        private System.Windows.Forms.TextBox usernameTextbox1;
        private System.Windows.Forms.Button signInButton1;
        private System.Windows.Forms.Label passwordLabel1;
        private System.Windows.Forms.TextBox passwordTextbox1;
        private System.Windows.Forms.LinkLabel signUpLinkLabel1;
    }
}

