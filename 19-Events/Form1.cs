using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World 1");
        }
        private void button1_Click2(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World 2");
        }
        private void button1_Click3(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World 3");
        }
    }
}
