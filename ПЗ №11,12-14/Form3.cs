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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Настрйка кнопки "На главную". При нажатии пользователя будет переносить на Form1(главное меню)*/
            DialogResult dialog = MessageBox.Show("Вы уверены?", "",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            /*Условие, при котором, если значение переменной dialog будет равен DialogResult.Yes, то Form3(Задание) закроеться, и пользователя перекинет на главное меню*/
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*обработка исключений с помощью try и cath*/
            try
            {
                /*Создание переменных, в которые пользователь будет вводить свои данные. Эти переменные в последствии будут использоваться для вычисления*/
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double x = double.Parse(textBox3.Text);

                /*Создание строк в textBox для вывода каждого значения переменной*/
                textBox4.Text += Environment.NewLine + "a =" + a.ToString();
                textBox4.Text += Environment.NewLine + "b =" + b.ToString();
                textBox4.Text += Environment.NewLine + "x =" + x.ToString();

                /*Вычисление арифметического выражения по заданной формуле*/
                /*Арифметическое выражение разделено на три части: n, m and k*/
                double n = Math.Sqrt(x * (b / a));
                double m = Math.Cos(2 * 2);
                double k = Math.Pow(x + b, 3);
                double y = n + m * k;

                /*Вывод результата из переменной u в textBox4*/
                textBox4.Text += Environment.NewLine + "Результат Y =" + y.ToString();
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
    }
}
