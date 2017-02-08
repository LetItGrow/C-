using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        double a;
        double b;
        string c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
            a = double.Parse(textBox1.Text);
            }
            c = "+";
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
            }
            c = "-";
            textBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
            }
            c = "*";
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
            }
            c = "/";
            textBox1.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
            }
            c = "x2";
            //textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
            }
            c = "sqrt";
            //textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
            }
            c = "log";
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = double.Parse(textBox1.Text);
            }
            c = "ln";
            //textBox1.Clear();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                switch (c)
                {
                    case "+": textBox1.Text = (a + double.Parse(textBox1.Text)).ToString(); break;
                    case "-": textBox1.Text = (a - double.Parse(textBox1.Text)).ToString(); break;
                    case "*": textBox1.Text = (a * double.Parse(textBox1.Text)).ToString(); break;
                    case "/": textBox1.Text = (a / double.Parse(textBox1.Text)).ToString(); break;
                    case "x2": textBox1.Text = a * a+""; break;
                    case "sqrt": textBox1.Text = Math.Sqrt(a)+""; break;
                    case "log": textBox1.Text = Math.Log(double.Parse(textBox1.Text), a)+""; break;
                    case "ln": textBox1.Text = Math.Log(a, Math.E)+""; break;
                }
            }
        }

    }
}
