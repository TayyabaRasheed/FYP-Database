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
    public partial class Evaluation : Form
    {
        private static Evaluation l = null;
        public Evaluation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
        public static Evaluation getInstance()
        {
            if (l == null)
            {
                l = new Evaluation();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void Evaluation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Evaluation Values(@Name,@TotalMarks,@TotalWeightage)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@TotalMarks", Convert.ToInt32(txtTotalMarks.Text));
            cmd.Parameters.AddWithValue("@TotalWeightage", Convert.ToInt32(txtMarksWeightage.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Evaluation details added Successfully", "Evaluation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
