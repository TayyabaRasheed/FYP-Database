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
    public partial class UpdateDeleteEvaluation : Form
    {
        private static UpdateDeleteEvaluation l = null;
        public UpdateDeleteEvaluation()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
        public static UpdateDeleteEvaluation getInstance()
        {
            if (l == null)
            {
                l = new UpdateDeleteEvaluation();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void UpdateDeleteEvaluation_Load(object sender, EventArgs e)
        {
            GetEvaluationRecord();
        }
        private void GetEvaluationRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Evaluation", con);

            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            gdEvaluation.DataSource = dt;
        }
        public int stdID { get; set; }
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

        private void updateDeleteAdvisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteAdvisor l = UpdateDeleteAdvisor.getInstance();
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

        private void updateDeleteEvaluationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
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

        private void gdEvaluation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stdID = Convert.ToInt32(gdEvaluation.SelectedRows[0].Cells[0].Value);
            txtName.Text = gdEvaluation.SelectedRows[0].Cells[1].Value.ToString();
            txtTotalMarks.Text = gdEvaluation.SelectedRows[0].Cells[2].Value.ToString();
            txtMarksWeightage.Text = gdEvaluation.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (stdID > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Evaluation SET @Id=Id,Name= @Name,TotalMarks=@TotalMarks,@TotalWeightage=TotalWeightage where Id=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.stdID);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", txtTotalMarks.Text);
                cmd.Parameters.AddWithValue("@TotalWeightage", txtMarksWeightage.Text);               

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEvaluationRecord();
                ClearTextBoxs();
            }
            else
            {
                MessageBox.Show("Select Evaluation for updation", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearTextBoxs()
        {
            stdID = 0;
            txtName.Clear();
            txtTotalMarks.Clear();
            txtMarksWeightage.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stdID > 0)
            {
                con.Open();
                SqlCommand cd = new SqlCommand("Delete GroupEvaluation where EvaluationId=@ID ", con);
                cd.CommandType = CommandType.Text;
                cd.Parameters.AddWithValue("@ID", this.stdID);
                cd.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand("Delete Evaluation where Id=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.stdID);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEvaluationRecord();
                ClearTextBoxs();
            }
            else
            {
                MessageBox.Show("Select an Advisor to Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
