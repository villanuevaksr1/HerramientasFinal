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
    public partial class CambioRol : Form
    {
        public CambioRol()
        {
            InitializeComponent();
        }

        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (rbAdmin.Checked)
            {
               AdminMenu adminmenu = new AdminMenu();
                this.Hide();
                adminmenu.Show();
            }
            else if (rbInst.Checked)
            {
                InstructorMenu instructorMenu = new InstructorMenu();
                this.Hide();
                instructorMenu.Show();
            }
            else if (rbClient.Checked)
            {
                ClienteMenu clienteMenu = new ClienteMenu();
                this.Hide();
                clienteMenu.Show();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una opción.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
           
        }

        private void CambioRol_Load(object sender, EventArgs e)
        {

        }
    }
}
