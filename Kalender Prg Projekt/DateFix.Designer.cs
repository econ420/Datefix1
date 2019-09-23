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
            this.contactListContactsListview = new System.Windows.Forms.ListView();
            this.NewUserContactsButton = new System.Windows.Forms.Button();
            this.appointmentTabPage1 = new System.Windows.Forms.TabPage();
            this.taskTabPage1 = new System.Windows.Forms.TabPage();
            this.accountTabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.contactsTabPage1.SuspendLayout();
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
            this.contactsTabPage1.Controls.Add(this.contactListContactsListview);
            this.contactsTabPage1.Controls.Add(this.NewUserContactsButton);
            this.contactsTabPage1.Location = new System.Drawing.Point(4, 22);
            this.contactsTabPage1.Name = "contactsTabPage1";
            this.contactsTabPage1.Size = new System.Drawing.Size(792, 424);
            this.contactsTabPage1.TabIndex = 4;
            this.contactsTabPage1.Text = "Kontakte";
            this.contactsTabPage1.UseVisualStyleBackColor = true;
            this.contactsTabPage1.Click += new System.EventHandler(this.ContactsTabPage1_Click);
            // 
            // contactListContactsListview
            // 
            this.contactListContactsListview.Location = new System.Drawing.Point(8, 29);
            this.contactListContactsListview.Name = "contactListContactsListview";
            this.contactListContactsListview.Size = new System.Drawing.Size(780, 385);
            this.contactListContactsListview.TabIndex = 1;
            this.contactListContactsListview.UseCompatibleStateImageBehavior = false;
            this.contactListContactsListview.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
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
            this.accountTabPage1.Location = new System.Drawing.Point(4, 22);
            this.accountTabPage1.Name = "accountTabPage1";
            this.accountTabPage1.Size = new System.Drawing.Size(792, 424);
            this.accountTabPage1.TabIndex = 3;
            this.accountTabPage1.Text = "Konto";
            this.accountTabPage1.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage calendarTabPage1;
        private System.Windows.Forms.TabPage appointmentTabPage1;
        private System.Windows.Forms.TabPage taskTabPage1;
        private System.Windows.Forms.TabPage accountTabPage1;
        private System.Windows.Forms.TabPage contactsTabPage1;
        private System.Windows.Forms.Button NewUserContactsButton;
        private System.Windows.Forms.ListView contactListContactsListview;
    }
}