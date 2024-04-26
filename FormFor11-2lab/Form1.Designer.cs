namespace NoteRecordApp
{
    partial class Form1
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
            this.GenerateDataButton = new System.Windows.Forms.Button();
            this.ReadDataButton = new System.Windows.Forms.Button();
            this.DisplayBirthdaysButton = new System.Windows.Forms.Button();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GenerateDataButton
            // 
            this.GenerateDataButton.Location = new System.Drawing.Point(12, 12);
            this.GenerateDataButton.Name = "GenerateDataButton";
            this.GenerateDataButton.Size = new System.Drawing.Size(134, 23);
            this.GenerateDataButton.TabIndex = 0;
            this.GenerateDataButton.Text = "Generate Data";
            this.GenerateDataButton.UseVisualStyleBackColor = true;
            this.GenerateDataButton.Click += new System.EventHandler(this.GenerateDataButton_Click);
            // 
            // ReadDataButton
            // 
            this.ReadDataButton.Location = new System.Drawing.Point(152, 12);
            this.ReadDataButton.Name = "ReadDataButton";
            this.ReadDataButton.Size = new System.Drawing.Size(134, 23);
            this.ReadDataButton.TabIndex = 1;
            this.ReadDataButton.Text = "Read Data";
            this.ReadDataButton.UseVisualStyleBackColor = true;
            this.ReadDataButton.Click += new System.EventHandler(this.ReadDataButton_Click);
            // 
            // DisplayBirthdaysButton
            // 
            this.DisplayBirthdaysButton.Location = new System.Drawing.Point(292, 12);
            this.DisplayBirthdaysButton.Name = "DisplayBirthdaysButton";
            this.DisplayBirthdaysButton.Size = new System.Drawing.Size(134, 23);
            this.DisplayBirthdaysButton.TabIndex = 2;
            this.DisplayBirthdaysButton.Text = "Display Birthdays";
            this.DisplayBirthdaysButton.UseVisualStyleBackColor = true;
            this.DisplayBirthdaysButton.Click += new System.EventHandler(this.DisplayBirthdaysButton_Click);
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.Location = new System.Drawing.Point(432, 14);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(100, 20);
            this.MonthTextBox.TabIndex = 3;
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.Location = new System.Drawing.Point(12, 41);
            this.DisplayTextBox.Multiline = true;
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(520, 235);
            this.DisplayTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 288);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.MonthTextBox);
            this.Controls.Add(this.DisplayBirthdaysButton);
            this.Controls.Add(this.ReadDataButton);
            this.Controls.Add(this.GenerateDataButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateDataButton;
        private System.Windows.Forms.Button ReadDataButton;
        private System.Windows.Forms.Button DisplayBirthdaysButton;
        private System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.TextBox DisplayTextBox;
    }
}