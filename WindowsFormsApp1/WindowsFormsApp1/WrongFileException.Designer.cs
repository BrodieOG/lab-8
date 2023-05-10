namespace WindowsFormsApp1
{
    partial class WrongFileExceptionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.WrongFileException_exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Попереднє збереження не було знайдено";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WrongFileException_exitButton
            // 
            this.WrongFileException_exitButton.BackColor = System.Drawing.SystemColors.Window;
            this.WrongFileException_exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongFileException_exitButton.Location = new System.Drawing.Point(134, 114);
            this.WrongFileException_exitButton.Name = "WrongFileException_exitButton";
            this.WrongFileException_exitButton.Size = new System.Drawing.Size(111, 35);
            this.WrongFileException_exitButton.TabIndex = 1;
            this.WrongFileException_exitButton.Text = "OK";
            this.WrongFileException_exitButton.UseVisualStyleBackColor = false;
            this.WrongFileException_exitButton.Click += new System.EventHandler(this.WrongFileException_exitButton_Click);
            // 
            // WrongFileExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.WrongFileException_exitButton);
            this.Controls.Add(this.label1);
            this.Name = "WrongFileExceptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmptyFileException";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WrongFileException_exitButton;
    }
}