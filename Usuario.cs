using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_final_herramientas_II
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        public Usuario(string nombre, string contraseña, string rol)
        {
            Nombre = nombre;
            Contraseña = contraseña;
            Rol = rol;
        }
    }

    public static class DatosGlobales
    {
        public static List<Usuario> UsuariosRegistrados = new List<Usuario>();
    }
}
