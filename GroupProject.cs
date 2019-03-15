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
    public partial class GroupProject : Form
    {
        private static GroupProject l = null;
        public GroupProject()
        {
            InitializeComponent();
        }
        public static GroupProject getInstance()
        {
            if (l == null)
            {
                l = new GroupProject();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
        public int PrjtID { get; set; }
        public int GroupID { get; set; }
        private void GetGroupRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from [Group]", con);

            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            gdGroupInfo.DataSource = dt;
        }
        private void GetProjectRecord()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Project", con);

            DataTable dt = new DataTable();
            

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            gdProjectInfo.DataSource = dt;
        }
        private void GroupProject_Load(object sender, EventArgs e)
        {
            GetProjectRecord();
            GetGroupRecord();
        }

        private void cmdAssignProject_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Insert into GroupProject Values (@ProjectId,@GroupId,@AssignmentDate)", con);
            cmd2.CommandType = CommandType.Text;

            cmd2.Parameters.AddWithValue("@GroupId", this.GroupID);




            cmd2.Parameters.AddWithValue("@ProjectId", this.PrjtID);
           
            
            cmd2.Parameters.AddWithValue("@AssignmentDate", dateTimePicker1.Value);
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Project Assigned to the Group Successfully", "Assignent", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gdGroupInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GroupID = Convert.ToInt32(gdGroupInfo.SelectedRows[0].Cells[0].Value);
            txtGroupId.Text = gdGroupInfo.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void gdProjectInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PrjtID = Convert.ToInt32(gdProjectInfo.SelectedRows[0].Cells[0].Value);
            txtProjectId.Text = gdProjectInfo.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
