using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace charSumm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Пример подсчета чисел в строке...";
        }


        int labelMaxSimvolResult;
        private void button2_Click(object sender, EventArgs e)
        {
            //у текста введенного в поле textBox1 удаляем символ (ы)

            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //текст введенный textBox1 в отображаем в  labelText

            labelText.Text = textBox1.Text;

            //отображаем количество символов введенных в  textBox1 в labelCharCount

            labelCharCount.Text = textBox1.Text.Length.ToString();

            labelMaxSimvolResult = textBox1.MaxLength - textBox1.Text.Length;
            labelMaxSimvol.Text = labelMaxSimvolResult.ToString();
        }
    }
}
