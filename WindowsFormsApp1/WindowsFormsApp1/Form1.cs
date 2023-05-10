using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point click; //створення об'єкту класу point для запису координат положення мишки
        Graphics cr; //створення графічного об'єкта ,що в результаті стане нашим смайлом
        int CrossLenght = 0, CrossThickness = 0;
        bool DrawingAllowed = false;//змінна для дозволу/заборони малювання смайла
        Cross Cross_=new Cross(); //об'єкт класу хрест
        XmlSerializer formatter; //об'єкт класу xmlсеріалізатора
        BinaryFormatter binaryFormatter;
        FileStream fs;  //файловий потік
        bool deserializationAllowed = (File.Exists("Cross.xml")); //змінна ,що визначатиме можливість десеріалізації
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (DrawingAllowed) //якщо  малювання дозволено
            {
                click=e.Location;
                cr = CreateGraphics();
                Cross_.Draw(click.X, click.Y, cr);// виклик методу малювання смайла
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //кнопка малювання хреста за параметрами
        {
            if (!(string.IsNullOrEmpty(CrossLength_textbox.Text) || string.IsNullOrEmpty(CrossThickness_textbox.Text))) //перевірка на пустоту полей
            {
                if (int.TryParse(CrossLength_textbox.Text, out CrossLenght)) //переведення в число значення довжини
                {
                    if (int.TryParse(CrossThickness_textbox.Text, out CrossThickness))//переведення в число значення товщини
                    {
                        Cross_ =new Cross(CrossLenght, CrossThickness); //передача в об'єкт характеристик
                        DrawingAllowed=true;
                    }
                }
                else
                {
                    MessageBox.Show("Ви не ввели довжину", "Помилка при введенні даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DrawingAllowed=false;
                }
            }
            else
            {
                MessageBox.Show("Введені не всі дані для малювання хреста", "Помилка при введенні даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DrawingAllowed=false;
            }
        }
        private void XMLserialize_button_Click(object sender, EventArgs e) //кнопка XML серіалізації
        {
            if (Cross_.CrossLenght!=0 && Cross_.CrossThickness!=0)
            {
                formatter = new XmlSerializer(typeof(Cross));
                fs=new FileStream("Cross.xml", FileMode.OpenOrCreate);
                formatter.Serialize(fs, Cross_);
                fs.Close();
                MessageBox.Show("Об'єкт успішно ріалізовано через XML серіалізацію", "Об'єкт серіалізовано", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // серіалізація об'єкту Cross в файловому потоці fs , форматі файлу xml
            }
            else
            {
                MessageBox.Show("Для того ,щоб зберегти характеристики хреста - його слід спершу намалювати", "Помилка при серіалізації даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // повідомлення у випадку пустих полів
            }
        }

        private void XMLdeserialize_button_Click(object sender, EventArgs e) //кнопка XML десеріалізації
        {
            if (deserializationAllowed)
            {
                if (File.Exists("Cross.xml")) // якщо існує файл
                {
                    try
                    {
                        fs=new FileStream("Cross.xml", FileMode.Open);
                        formatter = new XmlSerializer(typeof(Cross));

                        Cross_= (Cross)formatter.Deserialize(fs);
                        fs.Close();

                        CrossLength_textbox.Text=Cross_.CrossLenght.ToString();
                        CrossThickness_textbox.Text=Cross_.CrossThickness.ToString();

                        DrawingAllowed=true;
                        MessageBox.Show("Об'єкт успішно десеріалізовано через XML десеріалізацію", "Об'єкт десеріалізовано", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //відбувається десеріалізація даних з файлу Cross.xml в об'єкт типу Cross ,після чого дозволяється малювання
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не вдалося десеріалізувати об'єкт", "Помилка при десеріалізації даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Не було знайдено файл з даними", "Помилка при десеріалізації даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //повідомлення користувача прор те ,що файл не було знайдено
                }
            }
            else
            {
                MessageBox.Show("Попереднє збереження не було знайдене", "Помилка при десеріалізації даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //виведення  повідомлення про те ,що даних в файлі немає
            }
        }

        private void Program_Characteristics_button_Click(object sender, EventArgs e) //кнопка отримання характеристик програми
        {
            Program_characteristics_form Characteristics = new Program_characteristics_form();
            Characteristics.SetInfo(Cross_.GetMethodsLine(), Cross_.GetPropertiesLine());
            Characteristics.Show();
            //метод ,в якому в вигляді рядків передаються значення назв методів та полів для відображення в окремій формі
        }

        private void BinarySerializeButton_Click(object sender, EventArgs e) //кнопка бінарної серіалізації
        {
            if (Cross_.CrossLenght!=0 && Cross_.CrossThickness!=0)
            {
                binaryFormatter = new BinaryFormatter();

                fs=new FileStream("Cross.dat", FileMode.OpenOrCreate);

                binaryFormatter.Serialize(fs, Cross_);
                fs.Close();
                MessageBox.Show("Об'єкт успішно ріалізовано через бінарну серіалізацію", "Об'єкт серіалізовано", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // серіалізація об'єкту Cross в файловому потоці fs , форматі файлу dat
            }
            else
            {
                MessageBox.Show("Для того ,щоб зберегти характеристики хреста - його слід спершу намалювати", "Помилка при серіалізації даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // повідомлення у випадку пустих полів
            }
        }

        private void BinaryDeserializeButton_Click(object sender, EventArgs e) //кнопка бінарної десеріалізації
        {
            if (deserializationAllowed)
            {
                if (File.Exists("Cross.dat")) // якщо існує файл
                {
                    try
                    {
                        fs=new FileStream("Cross.dat", FileMode.Open);
                        binaryFormatter = new BinaryFormatter();

                        Cross_= (Cross)binaryFormatter.Deserialize(fs);
                        fs.Close();

                        CrossLength_textbox.Text=Cross_.CrossLenght.ToString();
                        CrossThickness_textbox.Text=Cross_.CrossThickness.ToString();

                        DrawingAllowed=true;
                        MessageBox.Show("Об'єкт успішно десеріалізовано через бінарну десеріалізацію", "Об'єкт десеріалізовано", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //відбувається десеріалізація даних з файлу Cross.dat в об'єкт типу Cross ,після чого дозволяється малювання
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не вдалося десеріалізувати об'єкт", "Помилка при десеріалізації даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Не було знайдено файл з даними", "Помилка при десеріалізації даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //повідомлення користувача прор те ,що файл не було знайдено
                }
            }
            else
            {
                MessageBox.Show("Попереднє збереження не було знайдене", "Помилка при десеріалізації даних", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //виведення  повідомлення про те ,що даних в файлі немає
            }
        }

        [Serializable]
        public class Cross
        {

            public int CrossLenght { get; set; } //поле довжини хреста ,з властивостями 
            public int CrossThickness { get; set; } //поле товщини хреста з властивостями 
            public Cross() //конструктор без параметрів 
            {
                CrossLenght=0;
                CrossThickness=0;
            }
            public Cross(int CrossLenght_, int CrossThickness_) //конструктор з параметрами
            {
                CrossLenght=CrossLenght_;
                CrossThickness=CrossThickness_;

            }
            public void Draw(int x, int y, Graphics cr) //метод малювання хреста
            {
                cr.Clear(Color.White); //попереднє очищення поверхні
                Rectangle rect1 = new Rectangle(x-(CrossLenght/2), y-(CrossThickness/2), CrossLenght, CrossThickness);
                Rectangle rect2 = new Rectangle(x-(CrossThickness/2), y-(CrossLenght/2), CrossThickness, CrossLenght);
                //створення двох прямокутників ,які перетинатимуться центрами ,утворюючи хрест
                cr.DrawRectangle(new Pen(Color.Blue, 10), rect1);
                cr.DrawRectangle(new Pen(Color.Blue, 10), rect2);
                //малювання прямокутників
                cr.FillRectangle(new SolidBrush(Color.Yellow), rect1);
                cr.FillRectangle(new SolidBrush(Color.Yellow), rect2);
                //замальовування прямокутників
            }
            static Type t = typeof(Cross); //об'єкт типу type ,що містить в собі інформацію про тип даного класу
            public string GetMethodsLine() //метод отримання рядка методів програми
            {
                MethodInfo[] methods = t.GetMethods();
                string methodsLine = "";
                foreach (MethodInfo method in methods)
                {
                    methodsLine+=$"{method.ToString()}\r\n";
                }
                return methodsLine;
                //отримання списку методів в масив ,та подальший запис них в рядок для передачі на форму для виведення
            }
            public string GetPropertiesLine() //метод отримання рядка властивостей програми
            {
                PropertyInfo[] properties = t.GetProperties();
                string propertiesLine = "";
                foreach (PropertyInfo property in properties)
                {
                    propertiesLine+=$"{property.ToString()} \r\n";
                }
                return propertiesLine;
                //отримання списку полей в масив ,та подальший запис них в рядок для передачі на форму для виведення
            }

        }
    }
}
