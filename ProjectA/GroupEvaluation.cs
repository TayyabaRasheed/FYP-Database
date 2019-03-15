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
    public partial class GroupEvaluation : Form
    {
        private static GroupEvaluation l = null;
        public GroupEvaluation()
        {
            InitializeComponent();
        }
        public static GroupEvaluation getInstance()
        {
            if (l == null)
            {
                l = new GroupEvaluation();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
        private int stdID;

        public int EvaluationID { get; set; }
        public int GroupID { get; set; }
        private void GetGroupRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from [Group]", con);

            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            gdGroup.DataSource = dt;
        }
        private void GetEvaluatioRecord()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Evaluation", con);

            DataTable dt = new DataTable();


            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            gdEvaluation.DataSource = dt;
        }
        private void GroupEvaluation_Load(object sender, EventArgs e)
        {
            GetEvaluatioRecord();
            GetGroupRecord();
        }

        private void gdEvaluation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EvaluationID = Convert.ToInt32(gdEvaluation.SelectedRows[0].Cells[0].Value);
        }

        private void gdGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GroupID = Convert.ToInt32(gdGroup.SelectedRows[0].Cells[0].Value);
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Insert into GroupEvaluation Values (@GroupId,@EvaluationId,@ObtainedMarks,@EvaluationDate)", con);
            cmd2.CommandType = CommandType.Text;

            cmd2.Parameters.AddWithValue("@GroupId", this.GroupID);




            cmd2.Parameters.AddWithValue("@EvaluationId", this.EvaluationID);
            cmd2.Parameters.AddWithValue("@ObtainedMarks", Convert.ToInt32(txtMarks.Text));

            cmd2.Parameters.AddWithValue("@EvaluationDate", dtpDate.Value);
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Group evaluated  Successfully", "GroupEvaluation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void seToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person l = Person.getInstance();
            l.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomePage l = HomePage.getInstance();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (EvaluationID > 0)
            {
                con.Open();
                SqlCommand cd = new SqlCommand("Delete GroupEvaluation where EvaluationId=@ID ", con);
                cd.CommandType = CommandType.Text;
                cd.Parameters.AddWithValue("@ID", this.EvaluationID);
                cd.ExecuteNonQuery();
                //SqlCommand cmd = new SqlCommand("Delete Advisor where Id=@ID ", con);
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@ID", this.stdID);
                //cmd.ExecuteNonQuery();
                GetEvaluatioRecord();
                con.Close();
                MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

               // GetAdvisorRecord();
               // ClearTextBoxs();
            }
            else
            {
                MessageBox.Show("Select an Advisor to Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editGroupEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEvaluation l = EditEvaluation.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
