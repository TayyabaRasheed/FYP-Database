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

        private void EditEvaluation_Load(object sender, EventArgs e)
        {

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
            EvaluationID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
        }
        private void button1_Click(object sender, EventArgs e)
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

        
    }
}
