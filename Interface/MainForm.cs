using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface.Schedule;

namespace Interface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void планыграфикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanSchedule ps = new PlanSchedule();
            this.Hide();
            ps.Closed += (s, args) => this.Close();
            ps.Show();
        }
    }
}
