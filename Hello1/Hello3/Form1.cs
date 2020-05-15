using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello3
{
    public partial class Form1 : Form
    {
        int flag;
        public Form1()
        {
            InitializeComponent();
            flag = 1;
            button1.Text = "нажми немя";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
                {
                    button1.Text = "меня нажааааали";
                    flag++;
                }
            else this.Close();
        }
    }
}
