namespace WindowsFormsApp1
{
    partial class WrongProportionExceptionForm
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
            this.WrongProportionException_label = new System.Windows.Forms.Label();
            this.WrongProportionException_exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WrongProportionException_label
            // 
            this.WrongProportionException_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongProportionException_label.Location = new System.Drawing.Point(12, 20);
            this.WrongProportionException_label.Name = "WrongProportionException_label";
            this.WrongProportionException_label.Size = new System.Drawing.Size(360, 83);
            this.WrongProportionException_label.TabIndex = 0;
            this.WrongProportionException_label.Text = "Пропорції радіусів не дозволяють побудувати рівний смайл ,\r\nспробуйте пропорцію 1" +
    ":4 ,або 1:5";
            // 
            // WrongProportionException_exitButton
            // 
            this.WrongProportionException_exitButton.BackColor = System.Drawing.SystemColors.Window;
            this.WrongProportionException_exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongProportionException_exitButton.Location = new System.Drawing.Point(127, 118);
            this.WrongProportionException_exitButton.Name = "WrongProportionException_exitButton";
            this.WrongProportionException_exitButton.Size = new System.Drawing.Size(112, 31);
            this.WrongProportionException_exitButton.TabIndex = 1;
            this.WrongProportionException_exitButton.Text = "OK";
            this.WrongProportionException_exitButton.UseVisualStyleBackColor = false;
            this.WrongProportionException_exitButton.Click += new System.EventHandler(this.WrongProportionException_exitButton_Click);
            // 
            // WrongProportionExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.WrongProportionException_exitButton);
            this.Controls.Add(this.WrongProportionException_label);
            this.Name = "WrongProportionExceptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wrong Proportion Exception";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WrongProportionException_label;
        private System.Windows.Forms.Button WrongProportionException_exitButton;
    }
}