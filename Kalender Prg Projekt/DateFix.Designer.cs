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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.StartpagelinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.calendarlinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.eventslinkLabel3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // StartpagelinkLabel1
            // 
            this.StartpagelinkLabel1.AutoSize = true;
            this.StartpagelinkLabel1.Location = new System.Drawing.Point(12, 9);
            this.StartpagelinkLabel1.Name = "StartpagelinkLabel1";
            this.StartpagelinkLabel1.Size = new System.Drawing.Size(51, 13);
            this.StartpagelinkLabel1.TabIndex = 0;
            this.StartpagelinkLabel1.TabStop = true;
            this.StartpagelinkLabel1.Text = "Startseite";
            this.StartpagelinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StartpagelinkLabel1_LinkClicked);
            // 
            // calendarlinkLabel2
            // 
            this.calendarlinkLabel2.AutoSize = true;
            this.calendarlinkLabel2.Location = new System.Drawing.Point(115, 9);
            this.calendarlinkLabel2.Name = "calendarlinkLabel2";
            this.calendarlinkLabel2.Size = new System.Drawing.Size(49, 13);
            this.calendarlinkLabel2.TabIndex = 1;
            this.calendarlinkLabel2.TabStop = true;
            this.calendarlinkLabel2.Text = "Kalender";
            this.calendarlinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // eventslinkLabel3
            // 
            this.eventslinkLabel3.AutoSize = true;
            this.eventslinkLabel3.Location = new System.Drawing.Point(205, 9);
            this.eventslinkLabel3.Name = "eventslinkLabel3";
            this.eventslinkLabel3.Size = new System.Drawing.Size(45, 13);
            this.eventslinkLabel3.TabIndex = 2;
            this.eventslinkLabel3.TabStop = true;
            this.eventslinkLabel3.Text = "Termine";
            this.eventslinkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EventslinkLabel3_LinkClicked);
            // 
            // DateFix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eventslinkLabel3);
            this.Controls.Add(this.calendarlinkLabel2);
            this.Controls.Add(this.StartpagelinkLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DateFix";
            this.Text = "DateFix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel StartpagelinkLabel1;
        private System.Windows.Forms.LinkLabel calendarlinkLabel2;
        private System.Windows.Forms.LinkLabel eventslinkLabel3;
    }
}