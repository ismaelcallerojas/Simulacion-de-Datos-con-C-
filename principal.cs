using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaidrollTeamWindowsFormsApp1
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            empleados em = new empleados();
            em.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productos pr = new productos();
            pr.ShowDialog();
        }

        private void user_Click(object sender, EventArgs e)
        {
            ejemplo ej = new ejemplo();
            panel1.Controls.Add(ej);
        }
    }
}
