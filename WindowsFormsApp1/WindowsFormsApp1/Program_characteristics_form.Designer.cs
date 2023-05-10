namespace WindowsFormsApp1
{
    partial class Program_characteristics_form
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
            this.Methods_label = new System.Windows.Forms.Label();
            this.Methods_textBox = new System.Windows.Forms.TextBox();
            this.Properties_label = new System.Windows.Forms.Label();
            this.Properties_textBox = new System.Windows.Forms.TextBox();
            this.Characteristics_exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Methods_label
            // 
            this.Methods_label.BackColor = System.Drawing.SystemColors.Window;
            this.Methods_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Methods_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Methods_label.Location = new System.Drawing.Point(83, 30);
            this.Methods_label.Name = "Methods_label";
            this.Methods_label.Size = new System.Drawing.Size(272, 47);
            this.Methods_label.TabIndex = 2;
            this.Methods_label.Text = "Методи";
            this.Methods_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Methods_textBox
            // 
            this.Methods_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.Methods_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Methods_textBox.Location = new System.Drawing.Point(83, 86);
            this.Methods_textBox.Multiline = true;
            this.Methods_textBox.Name = "Methods_textBox";
            this.Methods_textBox.ReadOnly = true;
            this.Methods_textBox.Size = new System.Drawing.Size(272, 282);
            this.Methods_textBox.TabIndex = 3;
            // 
            // Properties_label
            // 
            this.Properties_label.BackColor = System.Drawing.SystemColors.Window;
            this.Properties_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Properties_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Properties_label.Location = new System.Drawing.Point(437, 30);
            this.Properties_label.Name = "Properties_label";
            this.Properties_label.Size = new System.Drawing.Size(272, 47);
            this.Properties_label.TabIndex = 4;
            this.Properties_label.Text = "Властивості";
            this.Properties_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Properties_textBox
            // 
            this.Properties_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.Properties_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Properties_textBox.Location = new System.Drawing.Point(437, 86);
            this.Properties_textBox.Multiline = true;
            this.Properties_textBox.Name = "Properties_textBox";
            this.Properties_textBox.ReadOnly = true;
            this.Properties_textBox.Size = new System.Drawing.Size(272, 282);
            this.Properties_textBox.TabIndex = 5;
            // 
            // Characteristics_exitButton
            // 
            this.Characteristics_exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Characteristics_exitButton.Location = new System.Drawing.Point(287, 393);
            this.Characteristics_exitButton.Name = "Characteristics_exitButton";
            this.Characteristics_exitButton.Size = new System.Drawing.Size(217, 45);
            this.Characteristics_exitButton.TabIndex = 6;
            this.Characteristics_exitButton.Text = "OK";
            this.Characteristics_exitButton.UseVisualStyleBackColor = false;
            this.Characteristics_exitButton.Click += new System.EventHandler(this.Characteristics_exitButton_Click);
            // 
            // Program_characteristics_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Characteristics_exitButton);
            this.Controls.Add(this.Properties_textBox);
            this.Controls.Add(this.Properties_label);
            this.Controls.Add(this.Methods_textBox);
            this.Controls.Add(this.Methods_label);
            this.Name = "Program_characteristics_form";
            this.Text = "Program characteristics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Methods_label;
        private System.Windows.Forms.TextBox Methods_textBox;
        private System.Windows.Forms.Label Properties_label;
        private System.Windows.Forms.TextBox Properties_textBox;
        private System.Windows.Forms.Button Characteristics_exitButton;
    }
}