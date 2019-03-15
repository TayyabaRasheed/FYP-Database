using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectA
{
    public partial class Person : Form
    {
        private static Person l = null;
        public Person()
        {
            InitializeComponent();
            GetStudentRecord();
            DatabaseConnection.getInstance().ConnectionString = "Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora";
        }
        public static Person getInstance()
        {
            if (l == null)
            {
                l = new Person();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void Person_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomePage l = HomePage.getInstance();
            l.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
        private void GetStudentRecord()
        {
           
            SqlCommand cmd = new SqlCommand("Select * from Person", con);

            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            
        }
        private void cmdSave_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                String frstname = txtFirstName.Text;
                String lstname = txtLastName.Text;
                String cntct = txtContact.Text;
                String mail = txtEmail.Text;
                DateTime db = dtpDOB.Value;
             
                int gndr;
                if (rdmale.Checked ==true)
                {
                    gndr = 1;
                }
                else 
                {
                    gndr = 2;
                }
                

                String cmd = String.Format("INSERT INTO Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values('{0}','{1}','{2}','{3}','{4}','{5}' )", frstname, lstname,cntct, mail, db, gndr);
                int rows = DatabaseConnection.getInstance().exectuteQuery(cmd);

                SqlCommand cdd = new SqlCommand("select IDENT_CURRENT('Person')", con);
                int s = Convert.ToInt32(cdd.ExecuteScalar());

                SqlCommand cd = new SqlCommand("Insert into Student Values (@Id,@RegistrationNo)", con);
                cd.CommandType = CommandType.Text;
                cd.Parameters.AddWithValue("@Id", s);
                cd.Parameters.AddWithValue("@RegistrationNo", txtReg.Text);
                cd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(String.Format("{0} rows affected", rows));
                GetStudentRecord();
                ClearTextBoxs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ClearTextBoxs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtFirstName.Focus();
        }
        private void Person_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseConnection.getInstance().closeConnection();
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

        private void addInstructorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void groupStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupStudents l = GroupStudents.getInstance();
            l.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            HomePage l = HomePage.getInstance();
            l.Show();
            this.Hide();
        }

        private void seToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Person l = Person.getInstance();
            l.Show();
            this.Hide();
        }

        private void searchStudentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StudentsRecord l = StudentsRecord.getInstance();
            l.Show();
            this.Hide();
        }

        private void editStudentDataToolStripMenuItem_Click_1(object sender, EventArgs e)
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
