using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        //Los datos que se tiene en la base de datos
        public string UsuarioLogin { get; set; }
        public string Contraseña { get; set; }
        public int Estado { get; set; }
    }
}
