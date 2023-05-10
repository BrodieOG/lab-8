namespace WindowsFormsApp1
{
    partial class EmptyDataException_form
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
            this.EmptyDataException_label = new System.Windows.Forms.Label();
            this.EmptyDataException_exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmptyDataException_label
            // 
            this.EmptyDataException_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmptyDataException_label.Location = new System.Drawing.Point(12, 9);
            this.EmptyDataException_label.Name = "EmptyDataException_label";
            this.EmptyDataException_label.Size = new System.Drawing.Size(360, 95);
            this.EmptyDataException_label.TabIndex = 0;
            this.EmptyDataException_label.Text = "Ви не ввели радіуси , намалювати смайл неможливо";
            this.EmptyDataException_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EmptyDataException_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmptyDataException_exitButton
            // 
            this.EmptyDataException_exitButton.BackColor = System.Drawing.SystemColors.Window;
            this.EmptyDataException_exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmptyDataException_exitButton.Location = new System.Drawing.Point(126, 117);
            this.EmptyDataException_exitButton.Name = "EmptyDataException_exitButton";
            this.EmptyDataException_exitButton.Size = new System.Drawing.Size(126, 32);
            this.EmptyDataException_exitButton.TabIndex = 1;
            this.EmptyDataException_exitButton.Text = "OK";
            this.EmptyDataException_exitButton.UseVisualStyleBackColor = false;
            this.EmptyDataException_exitButton.Click += new System.EventHandler(this.EmptyDataException_exitButton_Click);
            // 
            // EmptyDataException_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.EmptyDataException_exitButton);
            this.Controls.Add(this.EmptyDataException_label);
            this.Name = "EmptyDataException_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empty Data Exception";
            this.Load += new System.EventHandler(this.EmptyDataException_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EmptyDataException_label;
        private System.Windows.Forms.Button EmptyDataException_exitButton;
    }
}