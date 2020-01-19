namespace Kalender_Prg_Projekt
{
    partial class CreateEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEvent));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveEvent = new System.Windows.Forms.Button();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.eventEndtDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.eventStartDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(127, 47);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Terminname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Termin Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Termin Schluss";
            // 
            // saveEvent
            // 
            this.saveEvent.Location = new System.Drawing.Point(17, 147);
            this.saveEvent.Name = "saveEvent";
            this.saveEvent.Size = new System.Drawing.Size(309, 23);
            this.saveEvent.TabIndex = 9;
            this.saveEvent.Text = "Speichern";
            this.saveEvent.UseVisualStyleBackColor = true;
            this.saveEvent.Click += new System.EventHandler(this.saveEvent_Click);
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(16, 9);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(211, 24);
            this.titleLabel1.TabIndex = 10;
            this.titleLabel1.Text = "Neuen Termin Erstellen";
            // 
            // eventEndtDateTimePicker1
            // 
            this.eventEndtDateTimePicker1.Location = new System.Drawing.Point(127, 98);
            this.eventEndtDateTimePicker1.Name = "eventEndtDateTimePicker1";
            this.eventEndtDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.eventEndtDateTimePicker1.TabIndex = 11;
            // 
            // eventStartDateTimePicker1
            // 
            this.eventStartDateTimePicker1.Location = new System.Drawing.Point(127, 73);
            this.eventStartDateTimePicker1.Name = "eventStartDateTimePicker1";
            this.eventStartDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.eventStartDateTimePicker1.TabIndex = 12;
            // 
            // CreateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 193);
            this.Controls.Add(this.eventStartDateTimePicker1);
            this.Controls.Add(this.eventEndtDateTimePicker1);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.saveEvent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateEvent";
            this.Text = "Neuen Termin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveEvent;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.DateTimePicker eventEndtDateTimePicker1;
        private System.Windows.Forms.DateTimePicker eventStartDateTimePicker1;
    }
}