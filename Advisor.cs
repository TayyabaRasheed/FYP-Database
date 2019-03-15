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
        private static Advisor l = null;
        public Advisor()
        {
            InitializeComponent();
            DatabaseConnection.getInstance().ConnectionString = "Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora";
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

            // cmd.CommandText = "select Max(AccountID)as maxID from Account";
            // cmd.CommandType = CommandType.Text;

            //connection.Open();
           // var reader = DatabaseConnection.getInstance().getData(cm);
           // int row = DatabaseConnection.getInstance().exectuteQuery(cm);
           // OleDbDataReader reader = command.ExecuteReader();

            //if (reader.Read())
            //{
            //    accounts = Convert.ToInt32(reader["maxID"]) + 1;
            //}

           // return accounts;

            // return accounts;




            try
            {
                int desg=0;
                if(comboBox1.Text== "Professor")
                {
                    desg = 6;
                }
                else if(comboBox1.Text== "Associate Professor")
                {
                    desg = 7;
                }
                else if(comboBox1.Text== "Assisstant Professor")
                {
                    desg = 8;
                }
                else if(comboBox1.Text== "Lecturer")
                {
                    desg = 9;
                }
                else if (comboBox1.Text == "Industry Professional")
                {
                    desg = 10;
                }
                decimal slry = Convert.ToDecimal(txtSalary.Text);
                int id = Convert.ToInt32( txtID.Text);
                String cmd = String.Format("INSERT INTO Advisor(Id,Designation,Salary) values('{0}','{1}','{2}')",id ,desg,slry);
                int rows = DatabaseConnection.getInstance().exectuteQuery(cmd);
                MessageBox.Show(String.Format("{0} rows affected", rows));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
            
        }
    }
}
