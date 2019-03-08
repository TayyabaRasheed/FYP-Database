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
            try
            {
                int desg=0;
                if(comboBox1.Text=="Chair Person")
                {
                    desg = 1;
                }
                else if(comboBox1.Text=="Professor")
                {
                    desg = 2;
                }
                else if(comboBox1.Text== "Assistant Professor")
                {
                    desg = 3;
                }
                else if(comboBox1.Text=="Lecturar")
                {
                    desg = 4;
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
    }
}
