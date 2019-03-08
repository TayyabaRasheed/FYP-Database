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
    public partial class HomePage : Form
    {
        private static HomePage l = null;
        public HomePage()
        {
            InitializeComponent();
        }
        public static HomePage getInstance()
        {
            if (l == null)
            {
                l = new HomePage();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void seToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person l = Person.getInstance();
            l.Show();
            this.Hide();
        }

        private void searchStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsRecord l = StudentsRecord.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
