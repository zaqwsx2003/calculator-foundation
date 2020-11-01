using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result1 = 0;
            int result2 = 0;
            int result3 = 0;

            result1 = int.Parse(textBox1.Text);
            result2 = int.Parse(textBox2.Text);

            result3 = result1 + result2;
            label1.Text = result3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result1 = 0;
            int result2 = 0;
            int result3 = 0;

            result1 = int.Parse(textBox1.Text);
            result2 = int.Parse(textBox2.Text);

            result3 = result1 - result2;
            label1.Text = result3.ToString();
        }
    }
}
