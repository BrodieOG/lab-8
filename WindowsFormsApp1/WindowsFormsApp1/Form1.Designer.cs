namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CrossLength_label = new System.Windows.Forms.Label();
            this.CrossThickness_label = new System.Windows.Forms.Label();
            this.CrossLength_textbox = new System.Windows.Forms.TextBox();
            this.CrossThickness_textbox = new System.Windows.Forms.TextBox();
            this.CrossDrawingButton = new System.Windows.Forms.Button();
            this.Cross_label = new System.Windows.Forms.Label();
            this.XMLserialize_button = new System.Windows.Forms.Button();
            this.XMLdeserialize_button = new System.Windows.Forms.Button();
            this.Program_Characteristics_button = new System.Windows.Forms.Button();
            this.BinarySerializeButton = new System.Windows.Forms.Button();
            this.BinaryDeserializeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrossLength_label
            // 
            this.CrossLength_label.BackColor = System.Drawing.SystemColors.Window;
            this.CrossLength_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrossLength_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrossLength_label.Location = new System.Drawing.Point(34, 89);
            this.CrossLength_label.Name = "CrossLength_label";
            this.CrossLength_label.Size = new System.Drawing.Size(170, 31);
            this.CrossLength_label.TabIndex = 0;
            this.CrossLength_label.Text = "довжина хреста";
            this.CrossLength_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CrossLength_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // CrossThickness_label
            // 
            this.CrossThickness_label.BackColor = System.Drawing.SystemColors.Window;
            this.CrossThickness_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrossThickness_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrossThickness_label.Location = new System.Drawing.Point(34, 155);
            this.CrossThickness_label.Name = "CrossThickness_label";
            this.CrossThickness_label.Size = new System.Drawing.Size(170, 31);
            this.CrossThickness_label.TabIndex = 1;
            this.CrossThickness_label.Text = "Товщина хреста";
            this.CrossThickness_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CrossLength_textbox
            // 
            this.CrossLength_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrossLength_textbox.Location = new System.Drawing.Point(34, 123);
            this.CrossLength_textbox.Name = "CrossLength_textbox";
            this.CrossLength_textbox.Size = new System.Drawing.Size(170, 29);
            this.CrossLength_textbox.TabIndex = 2;
            // 
            // CrossThickness_textbox
            // 
            this.CrossThickness_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrossThickness_textbox.Location = new System.Drawing.Point(34, 189);
            this.CrossThickness_textbox.Name = "CrossThickness_textbox";
            this.CrossThickness_textbox.Size = new System.Drawing.Size(170, 29);
            this.CrossThickness_textbox.TabIndex = 3;
            // 
            // CrossDrawingButton
            // 
            this.CrossDrawingButton.BackColor = System.Drawing.SystemColors.Window;
            this.CrossDrawingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrossDrawingButton.Location = new System.Drawing.Point(34, 237);
            this.CrossDrawingButton.Name = "CrossDrawingButton";
            this.CrossDrawingButton.Size = new System.Drawing.Size(170, 29);
            this.CrossDrawingButton.TabIndex = 4;
            this.CrossDrawingButton.Text = "Намалювати хрест";
            this.CrossDrawingButton.UseVisualStyleBackColor = false;
            this.CrossDrawingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cross_label
            // 
            this.Cross_label.BackColor = System.Drawing.SystemColors.Window;
            this.Cross_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cross_label.Location = new System.Drawing.Point(226, 9);
            this.Cross_label.Name = "Cross_label";
            this.Cross_label.Size = new System.Drawing.Size(379, 65);
            this.Cross_label.TabIndex = 5;
            this.Cross_label.Text = "Cross";
            this.Cross_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XMLserialize_button
            // 
            this.XMLserialize_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XMLserialize_button.Location = new System.Drawing.Point(34, 312);
            this.XMLserialize_button.Name = "XMLserialize_button";
            this.XMLserialize_button.Size = new System.Drawing.Size(170, 27);
            this.XMLserialize_button.TabIndex = 6;
            this.XMLserialize_button.Text = "Серіалізувати в XML";
            this.XMLserialize_button.UseVisualStyleBackColor = false;
            this.XMLserialize_button.Click += new System.EventHandler(this.XMLserialize_button_Click);
            // 
            // XMLdeserialize_button
            // 
            this.XMLdeserialize_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XMLdeserialize_button.Location = new System.Drawing.Point(34, 345);
            this.XMLdeserialize_button.Name = "XMLdeserialize_button";
            this.XMLdeserialize_button.Size = new System.Drawing.Size(170, 26);
            this.XMLdeserialize_button.TabIndex = 7;
            this.XMLdeserialize_button.Text = "Десеріалізувати з XML";
            this.XMLdeserialize_button.UseVisualStyleBackColor = false;
            this.XMLdeserialize_button.Click += new System.EventHandler(this.XMLdeserialize_button_Click);
            // 
            // Program_Characteristics_button
            // 
            this.Program_Characteristics_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Program_Characteristics_button.Location = new System.Drawing.Point(34, 520);
            this.Program_Characteristics_button.Name = "Program_Characteristics_button";
            this.Program_Characteristics_button.Size = new System.Drawing.Size(170, 49);
            this.Program_Characteristics_button.TabIndex = 8;
            this.Program_Characteristics_button.Text = "Характеристики програми";
            this.Program_Characteristics_button.UseVisualStyleBackColor = false;
            this.Program_Characteristics_button.Click += new System.EventHandler(this.Program_Characteristics_button_Click);
            // 
            // BinarySerializeButton
            // 
            this.BinarySerializeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BinarySerializeButton.Location = new System.Drawing.Point(34, 393);
            this.BinarySerializeButton.Name = "BinarySerializeButton";
            this.BinarySerializeButton.Size = new System.Drawing.Size(170, 27);
            this.BinarySerializeButton.TabIndex = 9;
            this.BinarySerializeButton.Text = "Серіалізувати в DAT";
            this.BinarySerializeButton.UseVisualStyleBackColor = false;
            this.BinarySerializeButton.Click += new System.EventHandler(this.BinarySerializeButton_Click);
            // 
            // BinaryDeserializeButton
            // 
            this.BinaryDeserializeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BinaryDeserializeButton.Location = new System.Drawing.Point(34, 426);
            this.BinaryDeserializeButton.Name = "BinaryDeserializeButton";
            this.BinaryDeserializeButton.Size = new System.Drawing.Size(170, 26);
            this.BinaryDeserializeButton.TabIndex = 10;
            this.BinaryDeserializeButton.Text = "Десеріалізувати з DAT";
            this.BinaryDeserializeButton.UseVisualStyleBackColor = false;
            this.BinaryDeserializeButton.Click += new System.EventHandler(this.BinaryDeserializeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(824, 591);
            this.Controls.Add(this.BinaryDeserializeButton);
            this.Controls.Add(this.BinarySerializeButton);
            this.Controls.Add(this.Program_Characteristics_button);
            this.Controls.Add(this.XMLdeserialize_button);
            this.Controls.Add(this.XMLserialize_button);
            this.Controls.Add(this.Cross_label);
            this.Controls.Add(this.CrossDrawingButton);
            this.Controls.Add(this.CrossThickness_textbox);
            this.Controls.Add(this.CrossLength_textbox);
            this.Controls.Add(this.CrossThickness_label);
            this.Controls.Add(this.CrossLength_label);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CrossLength_label;
        private System.Windows.Forms.Label CrossThickness_label;
        private System.Windows.Forms.TextBox CrossLength_textbox;
        private System.Windows.Forms.TextBox CrossThickness_textbox;
        private System.Windows.Forms.Button CrossDrawingButton;
        private System.Windows.Forms.Label Cross_label;
        private System.Windows.Forms.Button XMLserialize_button;
        private System.Windows.Forms.Button XMLdeserialize_button;
        private System.Windows.Forms.Button Program_Characteristics_button;
        private System.Windows.Forms.Button BinarySerializeButton;
        private System.Windows.Forms.Button BinaryDeserializeButton;
    }
}

