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
    public partial class PlanScheduleOne : Form
    {
        public PlanScheduleOne()
        {
            InitializeComponent();
            testFunction();
        }

        private void testFunction()
        {
            dataGridView1.Rows.Add("Январь", "02.01.2023", "27.01.2023", "12");
        }
    }
}
