namespace Kalender_Prg_Projekt
{
    partial class Sign_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_Up));
            this.firstnameLabel1 = new System.Windows.Forms.Label();
            this.firstnameTextbox1 = new System.Windows.Forms.TextBox();
            this.lastnameLabel1 = new System.Windows.Forms.Label();
            this.lastnameTextbox1 = new System.Windows.Forms.TextBox();
            this.usernameLabel1 = new System.Windows.Forms.Label();
            this.usernameTextbox1 = new System.Windows.Forms.TextBox();
            this.passwordLabel1 = new System.Windows.Forms.Label();
            this.passwordConfirmLabel1 = new System.Windows.Forms.Label();
            this.birthdateLabel1 = new System.Windows.Forms.Label();
            this.passwordTextbox1 = new System.Windows.Forms.TextBox();
            this.passwordConfirmTextbox1 = new System.Windows.Forms.TextBox();
            this.sign_UpButton1 = new System.Windows.Forms.Button();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.addressLabel1 = new System.Windows.Forms.Label();
            this.emailTextbox1 = new System.Windows.Forms.TextBox();
            this.addressTextbox1 = new System.Windows.Forms.TextBox();
            this.birthdateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // firstnameLabel1
            // 
            this.firstnameLabel1.AutoSize = true;
            this.firstnameLabel1.Location = new System.Drawing.Point(32, 32);
            this.firstnameLabel1.Name = "firstnameLabel1";
            this.firstnameLabel1.Size = new System.Drawing.Size(49, 13);
            this.firstnameLabel1.TabIndex = 0;
            this.firstnameLabel1.Text = "Vorname";
            // 
            // firstnameTextbox1
            // 
            this.firstnameTextbox1.Location = new System.Drawing.Point(139, 29);
            this.firstnameTextbox1.Name = "firstnameTextbox1";
            this.firstnameTextbox1.Size = new System.Drawing.Size(200, 20);
            this.firstnameTextbox1.TabIndex = 1;
            // 
            // lastnameLabel1
            // 
            this.lastnameLabel1.AutoSize = true;
            this.lastnameLabel1.Location = new System.Drawing.Point(32, 60);
            this.lastnameLabel1.Name = "lastnameLabel1";
            this.lastnameLabel1.Size = new System.Drawing.Size(59, 13);
            this.lastnameLabel1.TabIndex = 2;
            this.lastnameLabel1.Text = "Nachname";
            // 
            // lastnameTextbox1
            // 
            this.lastnameTextbox1.Location = new System.Drawing.Point(139, 57);
            this.lastnameTextbox1.Name = "lastnameTextbox1";
            this.lastnameTextbox1.Size = new System.Drawing.Size(200, 20);
            this.lastnameTextbox1.TabIndex = 3;
            // 
            // usernameLabel1
            // 
            this.usernameLabel1.AutoSize = true;
            this.usernameLabel1.Location = new System.Drawing.Point(32, 88);
            this.usernameLabel1.Name = "usernameLabel1";
            this.usernameLabel1.Size = new System.Drawing.Size(75, 13);
            this.usernameLabel1.TabIndex = 4;
            this.usernameLabel1.Text = "Benutzername";
            // 
            // usernameTextbox1
            // 
            this.usernameTextbox1.Location = new System.Drawing.Point(139, 85);
            this.usernameTextbox1.Name = "usernameTextbox1";
            this.usernameTextbox1.Size = new System.Drawing.Size(200, 20);
            this.usernameTextbox1.TabIndex = 5;
            // 
            // passwordLabel1
            // 
            this.passwordLabel1.AutoSize = true;
            this.passwordLabel1.Location = new System.Drawing.Point(32, 116);
            this.passwordLabel1.Name = "passwordLabel1";
            this.passwordLabel1.Size = new System.Drawing.Size(50, 13);
            this.passwordLabel1.TabIndex = 6;
            this.passwordLabel1.Text = "Passwort";
            // 
            // passwordConfirmLabel1
            // 
            this.passwordConfirmLabel1.AutoSize = true;
            this.passwordConfirmLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordConfirmLabel1.Location = new System.Drawing.Point(32, 144);
            this.passwordConfirmLabel1.Name = "passwordConfirmLabel1";
            this.passwordConfirmLabel1.Size = new System.Drawing.Size(102, 13);
            this.passwordConfirmLabel1.TabIndex = 7;
            this.passwordConfirmLabel1.Text = "Passwort bestätigen";
            // 
            // birthdateLabel1
            // 
            this.birthdateLabel1.AutoSize = true;
            this.birthdateLabel1.Location = new System.Drawing.Point(32, 174);
            this.birthdateLabel1.Name = "birthdateLabel1";
            this.birthdateLabel1.Size = new System.Drawing.Size(73, 13);
            this.birthdateLabel1.TabIndex = 8;
            this.birthdateLabel1.Text = "Geburtsdatum";
            // 
            // passwordTextbox1
            // 
            this.passwordTextbox1.Location = new System.Drawing.Point(139, 113);
            this.passwordTextbox1.Name = "passwordTextbox1";
            this.passwordTextbox1.Size = new System.Drawing.Size(200, 20);
            this.passwordTextbox1.TabIndex = 9;
            this.passwordTextbox1.UseSystemPasswordChar = true;
            this.passwordTextbox1.TextChanged += new System.EventHandler(this.PasswordConfirmationCorrect_Textchanged);
            // 
            // passwordConfirmTextbox1
            // 
            this.passwordConfirmTextbox1.Location = new System.Drawing.Point(139, 141);
            this.passwordConfirmTextbox1.Name = "passwordConfirmTextbox1";
            this.passwordConfirmTextbox1.Size = new System.Drawing.Size(200, 20);
            this.passwordConfirmTextbox1.TabIndex = 10;
            this.passwordConfirmTextbox1.UseSystemPasswordChar = true;
            this.passwordConfirmTextbox1.TextChanged += new System.EventHandler(this.PasswordConfirmationCorrect_Textchanged);
            // 
            // sign_UpButton1
            // 
            this.sign_UpButton1.Location = new System.Drawing.Point(35, 261);
            this.sign_UpButton1.Name = "sign_UpButton1";
            this.sign_UpButton1.Size = new System.Drawing.Size(304, 23);
            this.sign_UpButton1.TabIndex = 12;
            this.sign_UpButton1.Text = "Registrieren";
            this.sign_UpButton1.UseVisualStyleBackColor = true;
            this.sign_UpButton1.Click += new System.EventHandler(this.Sign_UpButton1_Click);
            // 
            // emailLabel1
            // 
            this.emailLabel1.AutoSize = true;
            this.emailLabel1.Location = new System.Drawing.Point(32, 202);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(36, 13);
            this.emailLabel1.TabIndex = 13;
            this.emailLabel1.Text = "E-Mail";
            // 
            // addressLabel1
            // 
            this.addressLabel1.AutoSize = true;
            this.addressLabel1.Location = new System.Drawing.Point(32, 230);
            this.addressLabel1.Name = "addressLabel1";
            this.addressLabel1.Size = new System.Drawing.Size(51, 13);
            this.addressLabel1.TabIndex = 14;
            this.addressLabel1.Text = "Addresse";
            // 
            // emailTextbox1
            // 
            this.emailTextbox1.Location = new System.Drawing.Point(139, 197);
            this.emailTextbox1.Name = "emailTextbox1";
            this.emailTextbox1.Size = new System.Drawing.Size(200, 20);
            this.emailTextbox1.TabIndex = 15;
            // 
            // addressTextbox1
            // 
            this.addressTextbox1.Location = new System.Drawing.Point(139, 225);
            this.addressTextbox1.Name = "addressTextbox1";
            this.addressTextbox1.Size = new System.Drawing.Size(200, 20);
            this.addressTextbox1.TabIndex = 16;
            // 
            // birthdateDateTimePicker1
            // 
            this.birthdateDateTimePicker1.Location = new System.Drawing.Point(139, 171);
            this.birthdateDateTimePicker1.Name = "birthdateDateTimePicker1";
            this.birthdateDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.birthdateDateTimePicker1.TabIndex = 17;
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 304);
            this.Controls.Add(this.birthdateDateTimePicker1);
            this.Controls.Add(this.addressTextbox1);
            this.Controls.Add(this.emailTextbox1);
            this.Controls.Add(this.addressLabel1);
            this.Controls.Add(this.emailLabel1);
            this.Controls.Add(this.sign_UpButton1);
            this.Controls.Add(this.passwordConfirmTextbox1);
            this.Controls.Add(this.passwordTextbox1);
            this.Controls.Add(this.birthdateLabel1);
            this.Controls.Add(this.passwordConfirmLabel1);
            this.Controls.Add(this.passwordLabel1);
            this.Controls.Add(this.usernameTextbox1);
            this.Controls.Add(this.usernameLabel1);
            this.Controls.Add(this.lastnameTextbox1);
            this.Controls.Add(this.lastnameLabel1);
            this.Controls.Add(this.firstnameTextbox1);
            this.Controls.Add(this.firstnameLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign_Up";
            this.Text = "Sign_Up";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sign_Up_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstnameLabel1;
        private System.Windows.Forms.TextBox firstnameTextbox1;
        private System.Windows.Forms.Label lastnameLabel1;
        private System.Windows.Forms.TextBox lastnameTextbox1;
        private System.Windows.Forms.Label usernameLabel1;
        private System.Windows.Forms.TextBox usernameTextbox1;
        private System.Windows.Forms.Label passwordLabel1;
        private System.Windows.Forms.Label passwordConfirmLabel1;
        private System.Windows.Forms.Label birthdateLabel1;
        private System.Windows.Forms.TextBox passwordTextbox1;
        private System.Windows.Forms.TextBox passwordConfirmTextbox1;
        private System.Windows.Forms.Button sign_UpButton1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.Label addressLabel1;
        private System.Windows.Forms.TextBox emailTextbox1;
        private System.Windows.Forms.TextBox addressTextbox1;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker1;
    }
}