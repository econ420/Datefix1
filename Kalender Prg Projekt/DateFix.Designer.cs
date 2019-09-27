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
            this.appointmentTabPage1 = new System.Windows.Forms.TabPage();
            this.taskTabPage1 = new System.Windows.Forms.TabPage();
            this.accountTabPage1 = new System.Windows.Forms.TabPage();
            this.appointmentsAppointmentsTextBox1 = new System.Windows.Forms.TextBox();
            this.birthdayAppointmentsTextBox2 = new System.Windows.Forms.TextBox();
            this.titelBirthdayAppointmentsLabel2 = new System.Windows.Forms.Label();
            this.titelAppointmentsAppointmentsLabel1 = new System.Windows.Forms.Label();
            this.appointmentsCalenderAppointmentsMonthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabControl1.SuspendLayout();
            this.appointmentTabPage1.SuspendLayout();
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
            this.contactsTabPage1.Location = new System.Drawing.Point(4, 22);
            this.contactsTabPage1.Name = "contactsTabPage1";
            this.contactsTabPage1.Size = new System.Drawing.Size(792, 424);
            this.contactsTabPage1.TabIndex = 4;
            this.contactsTabPage1.Text = "Kontakte";
            this.contactsTabPage1.UseVisualStyleBackColor = true;
            // 
            // appointmentTabPage1
            // 
            this.appointmentTabPage1.Controls.Add(this.appointmentsCalenderAppointmentsMonthCalendar1);
            this.appointmentTabPage1.Controls.Add(this.titelAppointmentsAppointmentsLabel1);
            this.appointmentTabPage1.Controls.Add(this.titelBirthdayAppointmentsLabel2);
            this.appointmentTabPage1.Controls.Add(this.birthdayAppointmentsTextBox2);
            this.appointmentTabPage1.Controls.Add(this.appointmentsAppointmentsTextBox1);
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
            // appointmentsAppointmentsTextBox1
            // 
            this.appointmentsAppointmentsTextBox1.Location = new System.Drawing.Point(384, 33);
            this.appointmentsAppointmentsTextBox1.Multiline = true;
            this.appointmentsAppointmentsTextBox1.Name = "appointmentsAppointmentsTextBox1";
            this.appointmentsAppointmentsTextBox1.Size = new System.Drawing.Size(400, 150);
            this.appointmentsAppointmentsTextBox1.TabIndex = 0;
            this.appointmentsAppointmentsTextBox1.Text = "\r\n\r\n";
            this.appointmentsAppointmentsTextBox1.TextChanged += new System.EventHandler(this.AppointmentstextBox1_TextChanged);
            // 
            // birthdayAppointmentsTextBox2
            // 
            this.birthdayAppointmentsTextBox2.Location = new System.Drawing.Point(384, 223);
            this.birthdayAppointmentsTextBox2.Multiline = true;
            this.birthdayAppointmentsTextBox2.Name = "birthdayAppointmentsTextBox2";
            this.birthdayAppointmentsTextBox2.Size = new System.Drawing.Size(400, 150);
            this.birthdayAppointmentsTextBox2.TabIndex = 1;
            this.birthdayAppointmentsTextBox2.TextChanged += new System.EventHandler(this.BirthdaytextBox2_TextChanged);
            // 
            // titelBirthdayAppointmentsLabel2
            // 
            this.titelBirthdayAppointmentsLabel2.AutoSize = true;
            this.titelBirthdayAppointmentsLabel2.Location = new System.Drawing.Point(384, 207);
            this.titelBirthdayAppointmentsLabel2.Name = "titelBirthdayAppointmentsLabel2";
            this.titelBirthdayAppointmentsLabel2.Size = new System.Drawing.Size(189, 13);
            this.titelBirthdayAppointmentsLabel2.TabIndex = 2;
            this.titelBirthdayAppointmentsLabel2.Text = "Die Geburstage der nächsten 14 Tage";
            // 
            // titelAppointmentsAppointmentsLabel1
            // 
            this.titelAppointmentsAppointmentsLabel1.AutoSize = true;
            this.titelAppointmentsAppointmentsLabel1.Location = new System.Drawing.Point(384, 17);
            this.titelAppointmentsAppointmentsLabel1.Name = "titelAppointmentsAppointmentsLabel1";
            this.titelAppointmentsAppointmentsLabel1.Size = new System.Drawing.Size(153, 13);
            this.titelAppointmentsAppointmentsLabel1.TabIndex = 3;
            this.titelAppointmentsAppointmentsLabel1.Text = "Termine der nächsten 14 Tage";
            // 
            // appointmentsCalenderAppointmentsMonthCalendar1
            // 
            this.appointmentsCalenderAppointmentsMonthCalendar1.Location = new System.Drawing.Point(9, 17);
            this.appointmentsCalenderAppointmentsMonthCalendar1.Name = "appointmentsCalenderAppointmentsMonthCalendar1";
            this.appointmentsCalenderAppointmentsMonthCalendar1.TabIndex = 4;
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
            this.appointmentTabPage1.ResumeLayout(false);
            this.appointmentTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage calendarTabPage1;
        private System.Windows.Forms.TabPage appointmentTabPage1;
        private System.Windows.Forms.TabPage taskTabPage1;
        private System.Windows.Forms.TabPage accountTabPage1;
        private System.Windows.Forms.TabPage contactsTabPage1;
        private System.Windows.Forms.TextBox appointmentsAppointmentsTextBox1;
        private System.Windows.Forms.TextBox birthdayAppointmentsTextBox2;
        private System.Windows.Forms.Label titelBirthdayAppointmentsLabel2;
        private System.Windows.Forms.Label titelAppointmentsAppointmentsLabel1;
        private System.Windows.Forms.MonthCalendar appointmentsCalenderAppointmentsMonthCalendar1;
    }
}