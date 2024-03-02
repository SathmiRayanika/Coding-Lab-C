using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string fname;
            string messageText;

            messageText = "Your name is:";

            fname = txtStrings.Text;
            MessageBox.Show(messageText + fname);

            textBox1.Text = messageText+fname;
        }
    }
}
