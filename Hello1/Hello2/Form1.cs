using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            if (textBox1.Text == "")
            {
                textBox2.Text = "вы ничего не ввели";
            }
            else
            {
                x = double.Parse(textBox1.Text);
                x *= 1.609;
                textBox2.Text = x+" км";
            }
        }
    }
}
