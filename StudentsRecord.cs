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
    public partial class StudentsRecord : Form
    {
        private static StudentsRecord l = null;
        public StudentsRecord()
        {
            InitializeComponent();
            DatabaseConnection.getInstance().ConnectionString = "Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora";
        }
        public static StudentsRecord getInstance()
        {
            if (l == null)
            {
                l = new StudentsRecord();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void StudentsRecord_Load(object sender, EventArgs e)
        {
            //String cmd = "Select * from Person";
            //var reader = DatabaseConnection.getInstance().getData(cmd);

            //List<MyStudent> students = new List<MyStudent>();
            //while (reader.Read())
            //{
            //    MyStudent std = new MyStudent();
            //    std.ID = (int)reader.GetValue(0);
            //    std.firstname = reader.GetString(1);                
            //    std.lastname = reader.GetString(2);
            //    std.contact = reader.GetString(3);
            //    std.email = reader.GetString(4);
            //    std.dob = reader.GetDateTime(5);
            //    std.gender =(int) reader.GetValue(6);
            //    students.Add(std);
            //}
            //dataGridView1.DataSource = students;
            GetStudentRecord();
        }

        private void GetStudentRecord()
        {
            SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
            SqlCommand cmd = new SqlCommand("Select * from Person", con);

            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            dataGridView1.DataSource = dt;
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
          
        }

        private void editStudentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent l = UpdateDeleteStudent.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
