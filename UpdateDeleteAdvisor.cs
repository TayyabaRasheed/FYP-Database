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
    public partial class UpdateDeleteAdvisor : Form
    {
        private static UpdateDeleteAdvisor l = null;
        public UpdateDeleteAdvisor()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");

        public static UpdateDeleteAdvisor getInstance()
        {
            if (l == null)
            {
                l = new UpdateDeleteAdvisor();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void UpdateDeleteAdvisor_Load(object sender, EventArgs e)
        {
            GetAdvisorRecord();
        }

        private void seToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person l = Person.getInstance();
            l.Show();
            this.Hide();
        }
        public int stdID { get; set; }
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
            this.Show();
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
        private void GetAdvisorRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Advisor", con);

            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            gdAdvisorRecord.DataSource = dt;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            con.Open();
            if (stdID > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Advisor SET @Id=Id,Designation= @Designation,Salary=@Salary where Id=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.stdID);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text));
                
                

                int desg = 0;
                if (comboBox1.Text == "Professor")
                {
                    desg = 6;
                }
                else if (comboBox1.Text == "Associate Professor")
                {
                    desg = 7;
                }
                else if (comboBox1.Text == "Assisstant Professor")
                {
                    desg = 8;
                }
                else if (comboBox1.Text == "Lecturer")
                {
                    desg = 9;
                }
                else if (comboBox1.Text == "Industry Professional")
                {
                    desg = 10;
                }
                cmd.Parameters.AddWithValue("@Designation", Convert.ToInt32(desg));
               
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAdvisorRecord();
                ClearTextBoxs();
            }
            else
            {
                MessageBox.Show("Select a Advisor for updation", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearTextBoxs()
        {
            stdID = 0;
            comboBox1.Text="";
            txtSalary.Clear();
            
        }

        private void gdAdvisorRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stdID = Convert.ToInt32(gdAdvisorRecord.SelectedRows[0].Cells[0].Value);
            if(Convert.ToInt32(gdAdvisorRecord.SelectedRows[0].Cells[1].Value)==(06))
            {
                comboBox1.Text = "Professor";
            }
           else if (Convert.ToInt32(gdAdvisorRecord.SelectedRows[0].Cells[1].Value) == (07))
            {
                comboBox1.Text = "Associate Professor";
            }
            else if (Convert.ToInt32(gdAdvisorRecord.SelectedRows[0].Cells[1].Value) == (08))
            {
                comboBox1.Text = "Assisstant Professor";
            }
            else if (Convert.ToInt32(gdAdvisorRecord.SelectedRows[0].Cells[1].Value) == (9))
            {
                comboBox1.Text = "Lecturer";
            }
            else if (Convert.ToInt32(gdAdvisorRecord.SelectedRows[0].Cells[1].Value) == (10))
            {
                comboBox1.Text = "Industry Professional";
            }
            txtSalary.Text = gdAdvisorRecord.SelectedRows[0].Cells[2].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stdID > 0)
            {
                con.Open();
                SqlCommand cd = new SqlCommand("Delete ProjectAdvisor where AdvisorId=@ID ", con);
                cd.CommandType = CommandType.Text;
                cd.Parameters.AddWithValue("@ID", this.stdID);
                cd.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand("Delete Advisor where Id=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.stdID);
                cmd.ExecuteNonQuery();
                
                con.Close();
                MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAdvisorRecord();
                ClearTextBoxs();
            }
            else
            {
                MessageBox.Show("Select an Advisor to Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
