namespace Kalender_Prg_Projekt
{
    partial class DeleteContact
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
            this.DeleteHeaderLable = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteExitButton = new System.Windows.Forms.Button();
            this.ConfirmDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteHeaderLable
            // 
            this.DeleteHeaderLable.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteHeaderLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteHeaderLable.Location = new System.Drawing.Point(0, 0);
            this.DeleteHeaderLable.Name = "DeleteHeaderLable";
            this.DeleteHeaderLable.Size = new System.Drawing.Size(212, 364);
            this.DeleteHeaderLable.TabIndex = 0;
            this.DeleteHeaderLable.Text = "Bitte geben Sie die ID des zulöschenden Kontaktes ein.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 1;
            // 
            // DeleteExitButton
            // 
            this.DeleteExitButton.Location = new System.Drawing.Point(12, 329);
            this.DeleteExitButton.Name = "DeleteExitButton";
            this.DeleteExitButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteExitButton.TabIndex = 2;
            this.DeleteExitButton.Text = "Abbrechen";
            this.DeleteExitButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmDeleteButton
            // 
            this.ConfirmDeleteButton.Location = new System.Drawing.Point(251, 329);
            this.ConfirmDeleteButton.Name = "ConfirmDeleteButton";
            this.ConfirmDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmDeleteButton.TabIndex = 3;
            this.ConfirmDeleteButton.Text = "Bestätigen";
            this.ConfirmDeleteButton.UseVisualStyleBackColor = true;
            // 
            // DeleteContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 364);
            this.Controls.Add(this.ConfirmDeleteButton);
            this.Controls.Add(this.DeleteExitButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeleteHeaderLable);
            this.Name = "DeleteContact";
            this.Text = "DeleteContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteHeaderLable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteExitButton;
        private System.Windows.Forms.Button ConfirmDeleteButton;
    }
}