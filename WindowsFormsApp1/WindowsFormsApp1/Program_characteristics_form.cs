using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Program_characteristics_form : Form
    {
        public Program_characteristics_form()
        {
            InitializeComponent();
        }

        private void Characteristics_exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Fields_textBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void SetInfo( string Methods, string Properties) 
        {
            Methods_textBox.Text=Methods;
            Properties_textBox.Text=Properties;
            //метод вставки даних про методи та поля класу в відповідні поля форми
        }
    }
}
