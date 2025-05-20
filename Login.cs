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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string usuario = txtLogin.Text;
            string contraseña = txtPassword.Text;

            Usuario encontrado = DatosGlobales.UsuariosRegistrados
                .FirstOrDefault(u => u.Nombre == usuario && u.Contraseña == contraseña);

            if (encontrado != null)
            {
                MessageBox.Show($"Bienvenido {encontrado.Rol}: {encontrado.Nombre}");

                // Abrir menú según el rol
                if (encontrado.Rol == "Administrador")
                {
                    AdminMenu adminMenu = new AdminMenu();
                    this.Hide();
                    adminMenu.Show();
                }
                else if (encontrado.Rol == "Instructor")
                {
                    InstructorMenu instructorMenu = new InstructorMenu();
                    this.Hide();
                    instructorMenu.Show();
                }
                else if (encontrado.Rol == "Cliente")
                {
                    ClienteMenu clienteMenu = new ClienteMenu();
                    this.Hide();
                    clienteMenu.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

