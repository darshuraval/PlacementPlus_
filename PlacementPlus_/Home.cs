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
    public partial class Home : Form
    {
		static string email;
        public Home(string user)
        {
			email = user;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Home h = new Home(email);
			h.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Student s = new Student(email);
			s.Show();
			this.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			JobDrive drive = new JobDrive(email);
			drive.Show();
			this.Hide();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Profile p = new Profile(email);
			p.Show();
			this.Hide();
		}
	}
}
