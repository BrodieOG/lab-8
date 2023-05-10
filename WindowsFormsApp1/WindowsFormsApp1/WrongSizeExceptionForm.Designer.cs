namespace WindowsFormsApp1
{
    partial class WrongSizeExceptionForm
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
            this.WrongSizeException_label = new System.Windows.Forms.Label();
            this.WrongSizeException_exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WrongSizeException_label
            // 
            this.WrongSizeException_label.BackColor = System.Drawing.SystemColors.Window;
            this.WrongSizeException_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongSizeException_label.Location = new System.Drawing.Point(12, 9);
            this.WrongSizeException_label.Name = "WrongSizeException_label";
            this.WrongSizeException_label.Size = new System.Drawing.Size(360, 83);
            this.WrongSizeException_label.TabIndex = 0;
            this.WrongSizeException_label.Text = "Смайл неможливо намалювати ,оскільки радіус очей не може перевищувати радіус голо" +
    "ви";
            this.WrongSizeException_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WrongSizeException_label.Click += new System.EventHandler(this.WrongSizeException_label_Click);
            // 
            // WrongSizeException_exitButton
            // 
            this.WrongSizeException_exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongSizeException_exitButton.Location = new System.Drawing.Point(130, 114);
            this.WrongSizeException_exitButton.Name = "WrongSizeException_exitButton";
            this.WrongSizeException_exitButton.Size = new System.Drawing.Size(123, 35);
            this.WrongSizeException_exitButton.TabIndex = 1;
            this.WrongSizeException_exitButton.Text = "OK";
            this.WrongSizeException_exitButton.UseVisualStyleBackColor = false;
            this.WrongSizeException_exitButton.Click += new System.EventHandler(this.WrongSizeException_exitButton_Click);
            // 
            // WrongSizeExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.WrongSizeException_exitButton);
            this.Controls.Add(this.WrongSizeException_label);
            this.Name = "WrongSizeExceptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wrong Size Exception ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WrongSizeException_label;
        private System.Windows.Forms.Button WrongSizeException_exitButton;
    }
}