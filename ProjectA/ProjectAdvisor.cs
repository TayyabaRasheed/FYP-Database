using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class ProjectAdvisor : Form
    {
        private static ProjectAdvisor l = null;
        public ProjectAdvisor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
        public int PrjtID { get; set; }
        public int advisorID { get; set; }
        public static ProjectAdvisor getInstance()
        {
            if (l == null)
            {
                l = new ProjectAdvisor();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void GetAdvisorRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Advisor", con);

            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            gdAdvisor.DataSource = dt;
        }
        private void GetProjectRecord()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Project", con);

            DataTable dt = new DataTable();


            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            gdProject.DataSource = dt;
        }
        private void ProjectAdvisor_Load(object sender, EventArgs e)
        {
            GetProjectRecord();
            GetAdvisorRecord();
        }

        private void gdProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PrjtID = Convert.ToInt32(gdProject.SelectedRows[0].Cells[0].Value);
        }

        private void gdAdvisor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            advisorID = Convert.ToInt32(gdAdvisor.SelectedRows[0].Cells[0].Value);
        }

        private void cmdAdvisor_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Insert into ProjectAdvisor Values (@AdvisorId,@ProjectId,@AdvisorRole,@AssignmentDate)", con);
            cmd2.CommandType = CommandType.Text;

            cmd2.Parameters.AddWithValue("@AdvisorId", this.advisorID);

            cmd2.Parameters.AddWithValue("@ProjectId", this.PrjtID);

            int role = 0;
            if (comboBox1.Text == "Main Advisor")
            {
                role = 11;
            }
            else if (comboBox1.Text == "Co-Advisror")
            {
                role = 12;
            }
            else if (comboBox1.Text == "Industry Advisor")
            {
                role = 14;
            }
            cmd2.Parameters.AddWithValue("@AdvisorRole", role);
            cmd2.Parameters.AddWithValue("@AssignmentDate", dtpAssignment.Value);
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Advisor Assigned to the Project Successfully", "Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomePage l = HomePage.getInstance();
            l.Show();
            this.Hide();
        }

        private void seToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person l = Person.getInstance();
            l.Show();
            this.Hide();
        }

        private void searchStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsRecord l = StudentsRecord.getInstance();
            l.Show();
            this.Hide();
        }

        private void editStudentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent l = UpdateDeleteStudent.getInstance();
            l.Show();
            this.Hide();
        }

        private void addAdvisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Advisor l = Advisor.getInstance();
            l.Show();
            this.Hide();
        }

        private void projectAdvisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectAdvisor l = ProjectAdvisor.getInstance();
            l.Show();
            this.Hide();
        }

        private void groupWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Evaluation l = Evaluation.getInstance();
            l.Show();
            this.Hide();
        }

        private void individualEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupEvaluation l = GroupEvaluation.getInstance();
            l.Show();
            this.Hide();
        }

        private void groupStudentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroupStudents l = GroupStudents.getInstance();
            l.Show();
            this.Hide();
        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project l = Project.getInstance();
            l.Show();
            this.Hide();
        }

        private void assignGroupProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupProject l = GroupProject.getInstance();
            l.Show();
            this.Hide();
        }

        private void updateDeleteAdvisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteAdvisor l = UpdateDeleteAdvisor.getInstance();
            l.Show();
            this.Hide();
        }

        private void updateDeleteEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteEvaluation l = UpdateDeleteEvaluation.getInstance();
            l.Show();
            this.Hide();
        }

        private void updateDeleteProjectDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteProject l = UpdateDeleteProject.getInstance();
            l.Show();
            this.Hide();
        }

        private void deleteGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteGroup l = DeleteGroup.getInstance();
            l.Show();
            this.Hide();
        }

        private void editGroupEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEvaluation l = EditEvaluation.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
