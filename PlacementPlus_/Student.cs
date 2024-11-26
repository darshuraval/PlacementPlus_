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
    public partial class Student : Form
    {
        static string user;
        public Student(string email)
        {
            user = email;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
            Profile p = new Profile(user);
            p.Show(); this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
            Student p = new Student(user);
			p.Show(); this.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{
            JobDrive p = new JobDrive(user);
            p.Show(); this.Hide();
		}

		private void button6_Click(object sender, EventArgs e)
		{
            Request request = new Request(user);
            request.Show(); this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{

		}
	}
}
