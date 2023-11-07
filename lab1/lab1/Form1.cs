using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        bool btn1 = false;
        bool btn2 = false;
        bool btn3 = false;
        bool btn4 = false;
        int count = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn1 = true;
            if (btn1 == true)
            {
                count += 1;
                btn1 = false;
            }
                        label4.Text = Convert.ToString(Convert.ToInt32(count));
            MessageBox.Show(Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)), "Результат");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn2 = true;
            if (btn2 == true)
            {
                count += 1;
                btn2 = false;
            }
            label4.Text = Convert.ToString(Convert.ToInt32(count));
            MessageBox.Show(Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn3 = true;
            if (btn3 == true)
            {
                count += 1;
                btn3 = false;
            }
            label4.Text = Convert.ToString(Convert.ToInt32(count));
            MessageBox.Show(Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn4 = true;
            if (btn4 == true)
            {
                count += 1;
                btn4 = false;
            }
            label4.Text = Convert.ToString(Convert.ToInt32(count));
            MessageBox.Show(Convert.ToString(Math.Pow(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))));
        }

        private void label4_Click(object sender, EventArgs e)
        {
        
        }
    }
}