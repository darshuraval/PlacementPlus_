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
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
        }

		private void button3_Click(object sender, EventArgs e)
		{
            Student student = new Student();
            student.Show(); this.Close();
		}

		private void button5_Click(object sender, EventArgs e)
		{
            JobDrive drive = new JobDrive();
            drive.Show(); this.Close();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Request request = new Request();
			request.Show(); this.Close();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Profile profile = new Profile();
			profile.Show(); this.Close();
		}
	}
}
