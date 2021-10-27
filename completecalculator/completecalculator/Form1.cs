using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace completecalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string str = "";
        double num1, num2, ans = 0;
        string op = "";
        private void button1_Click(object sender, EventArgs e)
        {
            str = str + button1.Text;
            textBox1.Text = str;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            str = str + button10.Text;
            textBox1.Text = str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            str = str + button2.Text;
            textBox1.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            str = str + button3.Text;
            textBox1.Text = str;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            str = str + button4.Text;
            textBox1.Text = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            str = str + button5.Text;
            textBox1.Text = str;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            str = str + button6.Text;
            textBox1.Text = str;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            str = str + button7.Text;
            textBox1.Text = str;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            str = str + button8.Text;
            textBox1.Text = str;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            str = str + button9.Text;
            textBox1.Text = str;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(textBox1.Text);
                str = "";
                label1.Text = label1.Text + "" + textBox1.Text;
                textBox1.Clear();
                op = button11.Text;
                textBox1.Text = op;
                label1.Text = label1.Text + "" + textBox1.Text;
            }
            catch(Exception e1)
            {
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox1.Text;
                s = s.Substring(0, textBox1.Text.Length - 1);
                textBox1.Text = s;
                str = str.Substring(0, textBox1.Text.Length - 1);
            }
            catch(Exception e3)
            {

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            str = "";
            label1.Text = label1.Text + "" + textBox1.Text;
            textBox1.Clear();
            op = button12.Text;
            textBox1.Text = op;
            label1.Text = label1.Text + "" + textBox1.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            str = "";
            label1.Text = label1.Text + "" + textBox1.Text;
            textBox1.Clear();
            op = button13.Text;
            textBox1.Text = op;
            label1.Text = label1.Text + "" + textBox1.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            str = str + button16.Text;
            textBox1.Text = str;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            str = "";
            label1.Text = label1.Text + "" + textBox1.Text;
            textBox1.Clear();
            op = button14.Text;
            textBox1.Text = op;
            label1.Text = label1.Text + "" + textBox1.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (num1 > 0)
                {
                    num2 = double.Parse(textBox1.Text);
                    label1.Text = label1.Text + "" + textBox1.Text;

                    switch(op)
                    {
                        case "+":
                            ans = num1 + num2;
                            break;
                        case "-":
                            ans = num1 - num2;
                            break;
                        case "*":
                            ans = num1 * num2;
                            break;
                        case "/":
                            ans = num1 / num2;
                            break;
                    }
                    textBox1.Text = ans.ToString();
                    str = "";
                    label1.Text = label1.Text + "=" + textBox1.Text;

                }
            }
            catch(Exception e2)
            {

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            str = "";
            textBox1.Clear();
            num1 = 0;
            num2 = 0;
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
