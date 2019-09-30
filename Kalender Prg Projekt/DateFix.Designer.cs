namespace Kalender_Prg_Projekt
{
    partial class DateFix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateFix));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.calendarTabPage1 = new System.Windows.Forms.TabPage();
            this.contactsTabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewUserContactsButton = new System.Windows.Forms.Button();
            this.appointmentTabPage1 = new System.Windows.Forms.TabPage();
            this.taskTabPage1 = new System.Windows.Forms.TabPage();
            this.accountTabPage1 = new System.Windows.Forms.TabPage();
            this.titleAccountSignInLabel1 = new System.Windows.Forms.Label();
            this.signUpAccountLinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.signInAccountButton1 = new System.Windows.Forms.Button();
            this.passwordAccountTextbox1 = new System.Windows.Forms.TextBox();
            this.usernameAccountTextbox1 = new System.Windows.Forms.TextBox();
            this.passwordAccountLabel1 = new System.Windows.Forms.Label();
            this.usernameAccountLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.contactsTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.accountTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.calendarTabPage1);
            this.tabControl1.Controls.Add(this.contactsTabPage1);
            this.tabControl1.Controls.Add(this.appointmentTabPage1);
            this.tabControl1.Controls.Add(this.taskTabPage1);
            this.tabControl1.Controls.Add(this.accountTabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 7;
            // 
            // calendarTabPage1
            // 
            this.calendarTabPage1.Location = new System.Drawing.Point(4, 22);
            this.calendarTabPage1.Name = "calendarTabPage1";
            this.calendarTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.calendarTabPage1.Size = new System.Drawing.Size(792, 424);
            this.calendarTabPage1.TabIndex = 0;
            this.calendarTabPage1.Text = "Kalendar";
            this.calendarTabPage1.UseVisualStyleBackColor = true;
            // 
            // contactsTabPage1
            // 
            this.contactsTabPage1.Controls.Add(this.dataGridView1);
            this.contactsTabPage1.Controls.Add(this.panel1);
            this.contactsTabPage1.Location = new System.Drawing.Point(4, 22);
            this.contactsTabPage1.Name = "contactsTabPage1";
            this.contactsTabPage1.Size = new System.Drawing.Size(792, 424);
            this.contactsTabPage1.TabIndex = 4;
            this.contactsTabPage1.Text = "Kontakte";
            this.contactsTabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 396);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewUserContactsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 28);
            this.panel1.TabIndex = 8;
            // 
            // NewUserContactsButton
            // 
            this.NewUserContactsButton.Location = new System.Drawing.Point(709, 3);
            this.NewUserContactsButton.Name = "NewUserContactsButton";
            this.NewUserContactsButton.Size = new System.Drawing.Size(75, 23);
            this.NewUserContactsButton.TabIndex = 0;
            this.NewUserContactsButton.Text = "Neu";
            this.NewUserContactsButton.UseVisualStyleBackColor = true;
            this.NewUserContactsButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // appointmentTabPage1
            // 
            this.appointmentTabPage1.Location = new System.Drawing.Point(4, 22);
            this.appointmentTabPage1.Name = "appointmentTabPage1";
            this.appointmentTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentTabPage1.Size = new System.Drawing.Size(792, 424);
            this.appointmentTabPage1.TabIndex = 1;
            this.appointmentTabPage1.Text = "Termine";
            this.appointmentTabPage1.UseVisualStyleBackColor = true;
            // 
            // taskTabPage1
            // 
            this.taskTabPage1.Location = new System.Drawing.Point(4, 22);
            this.taskTabPage1.Name = "taskTabPage1";
            this.taskTabPage1.Size = new System.Drawing.Size(792, 424);
            this.taskTabPage1.TabIndex = 2;
            this.taskTabPage1.Text = "Aufgaben";
            this.taskTabPage1.UseVisualStyleBackColor = true;
            // 
            // accountTabPage1
            // 
            this.accountTabPage1.Controls.Add(this.titleAccountSignInLabel1);
            this.accountTabPage1.Controls.Add(this.signUpAccountLinkLabel1);
            this.accountTabPage1.Controls.Add(this.signInAccountButton1);
            this.accountTabPage1.Controls.Add(this.passwordAccountTextbox1);
            this.accountTabPage1.Controls.Add(this.usernameAccountTextbox1);
            this.accountTabPage1.Controls.Add(this.passwordAccountLabel1);
            this.accountTabPage1.Controls.Add(this.usernameAccountLabel1);
            this.accountTabPage1.Location = new System.Drawing.Point(4, 22);
            this.accountTabPage1.Name = "accountTabPage1";
            this.accountTabPage1.Size = new System.Drawing.Size(792, 424);
            this.accountTabPage1.TabIndex = 3;
            this.accountTabPage1.Text = "Konto";
            this.accountTabPage1.UseVisualStyleBackColor = true;
            // 
            // titleAccountSignInLabel1
            // 
            this.titleAccountSignInLabel1.AutoSize = true;
            this.titleAccountSignInLabel1.Location = new System.Drawing.Point(532, 83);
            this.titleAccountSignInLabel1.Name = "titleAccountSignInLabel1";
            this.titleAccountSignInLabel1.Size = new System.Drawing.Size(33, 13);
            this.titleAccountSignInLabel1.TabIndex = 12;
            this.titleAccountSignInLabel1.Text = "Login";
            // 
            // signUpAccountLinkLabel1
            // 
            this.signUpAccountLinkLabel1.AutoSize = true;
            this.signUpAccountLinkLabel1.Location = new System.Drawing.Point(532, 216);
            this.signUpAccountLinkLabel1.Name = "signUpAccountLinkLabel1";
            this.signUpAccountLinkLabel1.Size = new System.Drawing.Size(94, 13);
            this.signUpAccountLinkLabel1.TabIndex = 11;
            this.signUpAccountLinkLabel1.TabStop = true;
            this.signUpAccountLinkLabel1.Text = "Jetzt Registrieren?";
            // 
            // signInAccountButton1
            // 
            this.signInAccountButton1.Location = new System.Drawing.Point(535, 181);
            this.signInAccountButton1.Name = "signInAccountButton1";
            this.signInAccountButton1.Size = new System.Drawing.Size(204, 23);
            this.signInAccountButton1.TabIndex = 10;
            this.signInAccountButton1.Text = "Anmelden";
            this.signInAccountButton1.UseVisualStyleBackColor = true;
            // 
            // passwordAccountTextbox1
            // 
            this.passwordAccountTextbox1.Location = new System.Drawing.Point(639, 145);
            this.passwordAccountTextbox1.Name = "passwordAccountTextbox1";
            this.passwordAccountTextbox1.Size = new System.Drawing.Size(100, 20);
            this.passwordAccountTextbox1.TabIndex = 9;
            this.passwordAccountTextbox1.UseSystemPasswordChar = true;
            // 
            // usernameAccountTextbox1
            // 
            this.usernameAccountTextbox1.Location = new System.Drawing.Point(639, 117);
            this.usernameAccountTextbox1.Name = "usernameAccountTextbox1";
            this.usernameAccountTextbox1.Size = new System.Drawing.Size(100, 20);
            this.usernameAccountTextbox1.TabIndex = 8;
            // 
            // passwordAccountLabel1
            // 
            this.passwordAccountLabel1.AutoSize = true;
            this.passwordAccountLabel1.Location = new System.Drawing.Point(532, 148);
            this.passwordAccountLabel1.Name = "passwordAccountLabel1";
            this.passwordAccountLabel1.Size = new System.Drawing.Size(50, 13);
            this.passwordAccountLabel1.TabIndex = 7;
            this.passwordAccountLabel1.Text = "Passwort";
            // 
            // usernameAccountLabel1
            // 
            this.usernameAccountLabel1.AutoSize = true;
            this.usernameAccountLabel1.Location = new System.Drawing.Point(0, 0);
            this.usernameAccountLabel1.Name = "usernameAccountLabel1";
            this.usernameAccountLabel1.Size = new System.Drawing.Size(75, 13);
            this.usernameAccountLabel1.TabIndex = 6;
            this.usernameAccountLabel1.Text = "Benutzername";
            // 
            // DateFix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DateFix";
            this.Text = "DateFix";
            this.tabControl1.ResumeLayout(false);
            this.contactsTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.accountTabPage1.ResumeLayout(false);
            this.accountTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage calendarTabPage1;
        private System.Windows.Forms.TabPage appointmentTabPage1;
        private System.Windows.Forms.TabPage taskTabPage1;
        private System.Windows.Forms.TabPage accountTabPage1;
        private System.Windows.Forms.TabPage contactsTabPage1;
        private System.Windows.Forms.Label titleAccountSignInLabel1;
        private System.Windows.Forms.LinkLabel signUpAccountLinkLabel1;
        private System.Windows.Forms.Button signInAccountButton1;
        private System.Windows.Forms.TextBox passwordAccountTextbox1;
        private System.Windows.Forms.TextBox usernameAccountTextbox1;
        private System.Windows.Forms.Label passwordAccountLabel1;
        private System.Windows.Forms.Label usernameAccountLabel1;
        private System.Windows.Forms.Button NewUserContactsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}