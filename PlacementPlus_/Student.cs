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
			LoadStudents();
        }

        private void Form1_Load(object sender, EventArgs e)
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
			AddStudent student = new AddStudent(user, 0);
			student.Show(); this.Hide();
		}
		private void LoadStudents()
		{
			Database db = new Database();
			string query = "SELECT Id, StudentName, Email, Mobile, Course, Batch FROM students"; // Query to fetch student data
			var result = db.Execute(query);

			if (result.success && result.data != null)
			{
				dataGridView1.DataSource = result.data;  // Bind the data to the DataGridView

				dataGridView1.Columns["Id"].Visible = false;  // Hide the ID column

				// Add "View Details" button column
				DataGridViewButtonColumn viewDetailsColumn = new DataGridViewButtonColumn
				{
					Name = "ViewDetails",
					HeaderText = "Action",
					Text = "View Details",
					UseColumnTextForButtonValue = true
				};
				dataGridView1.Columns.Add(viewDetailsColumn);

				// Style the "View Details" button column
				dataGridView1.Columns["ViewDetails"].DefaultCellStyle.BackColor = Color.LightBlue;
				dataGridView1.Columns["ViewDetails"].DefaultCellStyle.ForeColor = Color.Black;

				// Add "Delete" button column
				DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
				{
					Name = "Delete",
					HeaderText = "Action",
					Text = "Delete",
					UseColumnTextForButtonValue = true
				};
				dataGridView1.Columns.Add(deleteColumn);

				// Style the "Delete" button column
				dataGridView1.Columns["Delete"].DefaultCellStyle.BackColor = Color.LightCoral;
				dataGridView1.Columns["Delete"].DefaultCellStyle.ForeColor = Color.Black;
			}
			else
			{
				MessageBox.Show("Failed to load student data.");
			}
		}

		// Event handler for when a user clicks a button in the DataGridView
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Database db = new Database();
			if (dataGridView1.Rows.Count == 0)
			{
				MessageBox.Show("No student data available.");
			}
			else
			{
				if (e.RowIndex >= 0)
				{
					// Handle the "View Details" button click
					if (e.ColumnIndex == dataGridView1.Columns["ViewDetails"].Index)
					{
						int studentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
						AddStudent detailsForm = new AddStudent(user, studentId);
						this.Hide();
						detailsForm.Show();
					}
					// Handle the "Delete" button click
					else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
					{
						int studentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
						db.Execute("DELETE FROM students WHERE Id = " + studentId);
						MessageBox.Show($"Deleted Student Record, StudentId: {studentId}");
						LoadStudents();  // Reload the student data
					}
				}
			}
		}
	}
}