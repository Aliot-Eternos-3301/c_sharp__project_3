using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПЗ__11_12_14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Настрйка кнопки "На главную". При нажатии пользователя будет переносить на Form1(главное меню)*/
            DialogResult = MessageBox.Show("Вы уверены?", "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            /*Условие, при котором, если значение переменной dialog будет равен DialogResult.Yes, то Form2(Упражнение) закроеться, и пользователя перекинет на главное меню*/
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            /*обработка исключений*/
            try
            {
                /*Создание переменных, в которые пользователь будет вводить свои данные. Эти переменные в последствии будут использоваться для вычисления*/
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                double z = double.Parse(textBox3.Text);

                /*Создание строк в textBox для вывода каждого значения переменной*/
                textBox4.Text += Environment.NewLine + "X =" + x.ToString();
                textBox4.Text += Environment.NewLine + "Y =" + y.ToString();
                textBox4.Text += Environment.NewLine + "Z =" + z.ToString();

                /*Вычисление арифметического выражения по заданной формуле*/
                /*Арифметическое выражение разделено на три части: a, b and c*/
                double a = Math.Tan(x + y) * Math.Tan(x + y);
                double b = Math.Exp(y - z);
                double c = Math.Sqrt(Math.Cos(x * x) + Math.Sin(z * z));
                double u = a - b * c;

                /*Вывод результата из переменной u в textBox4*/
                textBox4.Text += Environment.NewLine + "Результат U =" + u.ToString();
            }
            catch
            {
                textBox4.Text = ("Error!");
            }

                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*Очистка текстовых полей(textBox)*/
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
