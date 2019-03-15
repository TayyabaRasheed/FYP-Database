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
    public partial class Group : Form
    {
        private static Group l = null;
        public Group()
        {
            InitializeComponent();
        }
        public static Group getInstance()
        {
            if (l == null)
            {
                l = new Group();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
        private void Group_Load(object sender, EventArgs e)
        {

        }
        public int GroupID { get; set; }
        private void cmdCreate_Click(object sender, EventArgs e)
        {
            con.Open();
            string st = "Group";
            SqlCommand cmd = new SqlCommand("Insert into [Group] Values (@Created_On)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Created_On", dateTimePicker1.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Group Created Successfully", "GroupCreated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupStudentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroupStudents l = GroupStudents.getInstance();
            l.Show();
            this.Hide();

        }
    }
}
