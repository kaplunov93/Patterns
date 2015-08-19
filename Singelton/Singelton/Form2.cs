using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singelton
{
    public partial class Form2 : Form
    {
        MySingelton single = MySingelton.GetRef();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            single.FirstName = textBox1.Text;
            single.LastName = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = single.FirstName;
            textBox2.Text = single.LastName;
        }
    }
}
