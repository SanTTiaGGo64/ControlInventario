using AccesoDatos.DAO;
using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class UsuarioLogica
    {
        private UsuarioDAO usuarioDao = new UsuarioDAO();
        public DataTable ComprobarUsuario(Usuario usuarioLog)
        {
            return usuarioDao.ComprobarUsuario(usuarioLog);
        }
        public DataTable ListarUsuario()
        {
            return usuarioDao.ListarUsuario();
        }
        public void InsertarUsuario(Usuario usuario)
        {
            usuarioDao.InsertarUsuario(usuario);
        }
        public void EliminarUsuario(Usuario usuario)
        {
            usuarioDao.EliminarUsuario(usuario);
        }
        public void ModificarUsuario(Usuario Idusuario)
        {
            usuarioDao.ModificarUsuario(Idusuario);
        }
    }
}
