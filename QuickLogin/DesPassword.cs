using System;
using System.Windows.Forms;
using QuickLogin.Connect;

namespace QuickLogin
{
    public partial class DesPassword : Form
    {
        public DesPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Comm.DecryptDES(textBox1.Text.Trim());
        }
    }
}
