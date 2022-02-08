using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_CustomExceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                Authenticate.Authentic(txt_User.Text, txt_Password.Text);
                MessageBox.Show("Succeed!");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
