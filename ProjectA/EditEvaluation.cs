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
    public partial class EditEvaluation : Form
    {
        public EditEvaluation()
        {
            InitializeComponent();
            GetEvaluatioRecord();
        }
        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
        private static EditEvaluation l = null;
       
        public static EditEvaluation getInstance()
        {
            if (l == null)
            {
                l = new EditEvaluation();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        public int EvaluationID { get;  set; }
        public int GroupID { get; set; }

        private void EditEvaluation_Load(object sender, EventArgs e)
        {
            GetEvaluatioRecord();
        }
        private void GetEvaluatioRecord()
        {
            
            SqlCommand cmd = new SqlCommand("Select * from GroupEvaluation", con);
           
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GroupID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            EvaluationID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (GroupID > 0)
            {
                con.Open();
                SqlCommand cd = new SqlCommand("Delete GroupEvaluation where GroupID=@ID ", con);
                cd.CommandType = CommandType.Text;
                cd.Parameters.AddWithValue("@ID", this.GroupID);
                cd.ExecuteNonQuery();
                //SqlCommand cmd = new SqlCommand("Delete Advisor where Id=@ID ", con);
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@ID", this.stdID);
                //cmd.ExecuteNonQuery();
                
                con.Close();
                MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetEvaluatioRecord();
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
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            if (GroupID > 0)
            {
                SqlCommand cmd = new SqlCommand("Update GroupEvaluation SET @EvaluationId=EvaluationId,@GroupId=GroupId,ObtainedMarks= @ObtainedMarks,EvaluationDate=@EvaluationDate where GroupId=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@GroupId", this.GroupID);
                cmd.Parameters.AddWithValue("@ID", this.GroupID);
                cmd.Parameters.AddWithValue("@EvaluationID", this.EvaluationID);
                cmd.Parameters.AddWithValue("@ObtainedMarks", Convert.ToDecimal(textBox1.Text));
                cmd.Parameters.AddWithValue("@EvaluationDate", dateTimePicker1.Value);               

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEvaluatioRecord();
               // ClearTextBoxs();
            }
            else
            {
                MessageBox.Show("Select a Advisor for updation", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            UpdateDeleteEvaluation l = UpdateDeleteEvaluation.getInstance();
            l.Show();
            this.Hide();
        }

        private void groupStudentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroupStudents l = GroupStudents.getInstance();
            l.Show();
            this.Hide();
        }

        private void deleteGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteGroup l = DeleteGroup.getInstance();
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

        private void updateDeleteProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteProject l = UpdateDeleteProject.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
