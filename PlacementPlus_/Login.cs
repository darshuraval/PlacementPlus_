using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlacementPlus_
{
    public partial class Login : Form
    {
        Submit submit = new Submit();
        public Login()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            submit.Login(email, password);
		}

		private void button3_Click(object sender, EventArgs e)
		{
            Register register = new Register();
            this.Hide();
            register.Show();
		}
	}
}
