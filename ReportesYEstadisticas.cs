using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_final_herramientas_II
{
    public partial class ReportesYEstadisticas : Form
    {
        public ReportesYEstadisticas()
        {
            InitializeComponent();
        }

        private void btnbackad2_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.Show();
        }
    }
}
