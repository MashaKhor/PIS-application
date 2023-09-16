using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface.Schedule
{
    public partial class PlanSchedule : Form
    {
        public PlanSchedule()
        {
            InitializeComponent();
            testFunction();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            Hide();
            mf.Closed += (s, args) => this.Close();
            mf.Show();
        }

        private void testFunction()
        {
            dataGridView1.Rows.Add("Тюменская область", "Тюмень");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PlanScheduleOne pso = new PlanScheduleOne();
            pso.Show();
        }
    }
}
