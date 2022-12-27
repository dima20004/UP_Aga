using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экзамен_Агафонов
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible=false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }
        
        private void выхожToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void enteringTheFirstFunction()
        {
            try
            {
                Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Вы ввели некорректный тип данных для X!\r\nПовторите попытку!");
                textBox1.Text = "";
                return;
            }
            try
            {
                Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Вы ввели некорректный тип данных для Y!\r\nПовторите попытку!");
                textBox2.Text = "";
                return;
            }
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);

            if (x > 2 && x * x - y * y < 36)
                {
                    MessageBox.Show($"Точка ({x};{y}) находится внутри функций");
                    toolStripStatusLabel1.Text = $"Точка ({x},{y}) находится внутри функций";
                }
                else if (x == 2 || x * x - y * y == 36)
                {
                    MessageBox.Show($"Точка ({x};{y}) находится на границах функций");
                    toolStripStatusLabel1.Text = $"Точка ({x},{y}) находится на границах функций";
                }
                else
                {
                    MessageBox.Show($"Точка ({x};{y}) находится вне функций");
                    toolStripStatusLabel1.Text = $"Точка ({x},{y}) находится вне функций";
                }
           
        }

        void enteringTheSecondFunction()
        {
            try
            {
                Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Вы ввели некорректный тип данных для X!\r\nПовторите попытку!");
                textBox1.Text = "";
                return;
            }
            try
            {
                Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Вы ввели некорректный тип данных для Y!\r\nПовторите попытку!");
                textBox2.Text = "";
                return;
            }
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
                if ((x > -1 && y > 0 && y < -x) || (x * x + y * y < 1 && x > 0 && y < 0))
                {
                    MessageBox.Show($"Точка ({x};{y}) находится внутри функций");
                    toolStripStatusLabel1.Text = $"Точка ({x};{y}) находится внутри функций";
                }
                else if ((x == -1 || y == 0 || y == -x) || (x * x + y * y == 1 || x == 0 || y == 0))
                {
                    MessageBox.Show($"Точка ({x},{y}) находится на границах функций");
                    toolStripStatusLabel1.Text = $"Точка ({x};{y}) находится на границах функций";
                }
                else
                {
                    MessageBox.Show($"Точка ({x},{y}) находится вне функций");
                    toolStripStatusLabel1.Text = $"Точка ({x};{y}) находится вне функций";
                }
            
            
        }

        public bool flag;
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                enteringTheFirstFunction();
            }
            else
            {
                enteringTheSecondFunction();
            }
        }

        private void оРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данное приложение разработал Агафонов Д.А.,\r\nСтудент группы ПКсп-120");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.AllowWebBrowserDrop = false;
            openFileDialog1.Filter = "TextFiles(*.html)|*.html|AllFiles(*.*)|*.*";
            openFileDialog1.ShowDialog();
            
            string[] repSplit = openFileDialog1.FileName.Split('\\');
            string curFile = repSplit[repSplit.Length - 1];
            if (curFile == "1.html")
            {
                webBrowser1.Navigate(openFileDialog1.FileName);
                flag = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
            }
            else if (curFile == "2.html")
            {
                webBrowser1.Navigate(openFileDialog1.FileName);
                flag = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
            }
            else
            {
                if (curFile == "openFileDialog1") 
                {
                   
                }
                else
                {
                    MessageBox.Show($"Для файла {curFile} нет решения. Выберите 1.html или 2.html");
                }
               
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Значение";
            textBox1.Text = "";
            textBox2.Text = "";
            webBrowser1.Navigate("");
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;


        }
    }
}
