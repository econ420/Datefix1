namespace Kalender_Prg_Projekt
{
    partial class NewContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewContact));
            this.txtBoxFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxAdresse = new System.Windows.Forms.TextBox();
            this.labHeader = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.birthdateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxFirstname
            // 
            this.txtBoxFirstname.Location = new System.Drawing.Point(129, 57);
            this.txtBoxFirstname.Name = "txtBoxFirstname";
            this.txtBoxFirstname.Size = new System.Drawing.Size(200, 20);
            this.txtBoxFirstname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nachname";
            // 
            // txtBoxLastname
            // 
            this.txtBoxLastname.Location = new System.Drawing.Point(129, 83);
            this.txtBoxLastname.Name = "txtBoxLastname";
            this.txtBoxLastname.Size = new System.Drawing.Size(200, 20);
            this.txtBoxLastname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Benutzername";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(129, 109);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(200, 20);
            this.txtBoxUsername.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birthdate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-mail";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(129, 161);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(200, 20);
            this.txtBoxEmail.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adresse";
            // 
            // txtBoxAdresse
            // 
            this.txtBoxAdresse.Location = new System.Drawing.Point(129, 187);
            this.txtBoxAdresse.Name = "txtBoxAdresse";
            this.txtBoxAdresse.Size = new System.Drawing.Size(200, 20);
            this.txtBoxAdresse.TabIndex = 10;
            // 
            // labHeader
            // 
            this.labHeader.AutoSize = true;
            this.labHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeader.Location = new System.Drawing.Point(12, 19);
            this.labHeader.Name = "labHeader";
            this.labHeader.Size = new System.Drawing.Size(233, 24);
            this.labHeader.TabIndex = 12;
            this.labHeader.Text = "Neuen Kontakt hinzufügen";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(251, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Speichern_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 329);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Abbrechen";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // birthdateDateTimePicker1
            // 
            this.birthdateDateTimePicker1.Location = new System.Drawing.Point(129, 135);
            this.birthdateDateTimePicker1.Name = "birthdateDateTimePicker1";
            this.birthdateDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.birthdateDateTimePicker1.TabIndex = 15;
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(12, 225);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(145, 13);
            this.labError.TabIndex = 16;
            this.labError.Text = "Bitte füllen Sie alle Felder aus";
            this.labError.Visible = false;
            // 
            // NewContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 364);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.birthdateDateTimePicker1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labHeader);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxAdresse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxLastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxFirstname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewContact";
            this.Text = "Neuer Kontakt ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxAdresse;
        private System.Windows.Forms.Label labHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker1;
        private System.Windows.Forms.Label labError;
    }
}