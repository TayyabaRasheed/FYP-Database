using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Person : Form
    {
        private static Person l = null;
        public Person()
        {
            InitializeComponent();
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

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                String frstname = txtFirstName.Text;
                String lstname = txtLastName.Text;
                String cntct = txtContact.Text;
                String mail = txtEmail.Text;
                DateTime db = dtpDOB.Value;
                int x = 0;
                int gndr;
                if (rdmale.Checked ==true)
                {
                    gndr = 1;
                }
                else 
                {
                    gndr = x;
                }
                

                String cmd = String.Format("INSERT INTO Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values('{0}','{1}','{2}','{3}','{4}','{5}' )", frstname, lstname,cntct, mail, db, gndr);
                int rows = DatabaseConnection.getInstance().exectuteQuery(cmd);
                MessageBox.Show(String.Format("{0} rows affected", rows));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Person_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseConnection.getInstance().closeConnection();
        }
    }
}
