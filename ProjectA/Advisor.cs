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
    public partial class Advisor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
        
        private static Advisor l = null;
        
        
        public Advisor()
        {
            InitializeComponent();
            GetAdvisorRecord();
            if (dataGridView1.RowCount == 0)
            {
                con.Open();
                SqlCommand cmd3 = new SqlCommand("Insert into Advisor Values (@Id,@Designation,@Salary)", con);
                cmd3.Parameters.AddWithValue("@Id", 1);
                cmd3.Parameters.AddWithValue("@Designation", 7);
                cmd3.Parameters.AddWithValue("@Salary", 10000);
                cmd3.ExecuteNonQuery();
                con.Close();
            }

            DatabaseConnection.getInstance().ConnectionString = "Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora";
        }
        private void GetAdvisorRecord()
        {
            SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
            SqlCommand cmd = new SqlCommand("Select * from Advisor", con);

            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            dataGridView1.DataSource = dt;
        }
        public static Advisor getInstance()
        {
            if (l == null)
            {
                l = new Advisor();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        
        private void cmdSave_Click(object sender, EventArgs e)
        {
            // String cm = "select Max(AdvisorId)as maxID from Advisor";
            // int accounts = 0;

            //  string output = "NULL";


            
            con.Open();
            //SqlCommand cmd3 = new SqlCommand("Insert into Advisor Values (@Id,@Designation,@Salary)", con);
            //cmd3.Parameters.AddWithValue("@Id", 1);
            //cmd3.Parameters.AddWithValue("@Designation", 7);
            //cmd3.Parameters.AddWithValue("@Salary", 10000);
            //cmd3.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand("select Max(Id)as maxID from Advisor", con);
            Int32 s = (Int32)cmd1.ExecuteScalar();
            
            
            // s = Convert.ToInt32(cmd1.ExecuteScalar());

            if (s>=1)
            {
                s = s + 1;
            }

            SqlCommand cmd2 = new SqlCommand("Insert into Advisor Values (@Id,@Designation,@Salary)", con);
            cmd2.CommandType = CommandType.Text;


            cmd2.Parameters.AddWithValue("@Id", s);
            
              
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
            cmd2.Parameters.AddWithValue("@Designation", desg);
            decimal slry = Convert.ToDecimal(txtSalary.Text);
            cmd2.Parameters.AddWithValue("@Salary", slry);

            // int id = Convert.ToInt32(txtID.Text);
            //String cmd = String.Format("INSERT INTO Advisor(Id,Designation,Salary) values('{0}','{1}','{2}')", s, desg, slry);
            //int rows = DatabaseConnection.getInstance().exectuteQuery(cmd);
            //MessageBox.Show(String.Format("{0} rows affected", rows));
            cmd2.ExecuteNonQuery();
            GetAdvisorRecord();
            con.Close();
            MessageBox.Show("Advisor Added  Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
           

        }
        private void Advisor_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseConnection.getInstance().closeConnection();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project l = Project.getInstance();
            l.Show();
            this.Hide();
        }

        private void groupStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupStudents l = GroupStudents.getInstance();
            l.Show();
            this.Hide();
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

        private void editStudentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent l = UpdateDeleteStudent.getInstance();
            l.Show();
            this.Hide();
        }

        private void searchStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsRecord l = StudentsRecord.getInstance();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void updateDeletePojectDetailsToolStripMenuItem_Click(object sender, EventArgs e)
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
