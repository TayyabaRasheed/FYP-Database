using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Project : Form
    {
        private static Project l = null;
        public Project()
        {
            InitializeComponent();
        }
        public static Project getInstance()
        {
            if (l == null)
            {
                l = new Project();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void Project_Load(object sender, EventArgs e)
        {

        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project l = Project.getInstance();
            l.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection("Data Source=TAYYABA-RASHEED;Initial Catalog=ProjectA;User ID=sa;Password=alohamora");
        
        private void cmdSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Project Values(@Description,@Title)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Description", txtDes.Text);
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Project Created Successfully", "ProjectCreated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
