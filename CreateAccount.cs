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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtClave.Text;
            string rol = cmbRol.SelectedItem?.ToString(); // Protege si no seleccionan

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            // Verificar si ya existe ese usuario
            bool existe = DatosGlobales.UsuariosRegistrados.Any(u => u.Nombre == usuario);
            if (existe)
            {
                MessageBox.Show("El nombre de usuario ya está registrado.");
                return;
            }

            // Agregar nuevo usuario a la lista
            Usuario nuevo = new Usuario(usuario, contraseña, rol);
            DatosGlobales.UsuariosRegistrados.Add(nuevo);

            // Abrir directamente el formulario de Login
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide(); // Oculta el formulario actual de registro

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
