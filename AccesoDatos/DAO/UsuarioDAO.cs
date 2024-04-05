using AccesoDatos.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccesoDatos.DAO
{
    public class UsuarioDAO
    {
        //1 - Realizar conexion a la BD - Consumir conexion - Crear instancia
        private ConexionBD conexion = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion = null;

        public DataTable ComprobarUsuario(Usuario usuarioLog)
        {
            DataTable dt = new DataTable();
            try
            {
                //1 - conectar bd
                ejecutarSql.Connection = conexion.AbrirConexion();
                //2 - sacar info de bd
                ejecutarSql.CommandText = "exec sps_comprobar_usuario '" + usuarioLog.UsuarioLogin + "','" + usuarioLog.Contraseña + "'";
                transaccion = ejecutarSql.ExecuteReader();
                //3 - almacenar data en un contenedor
                dt.Load(transaccion);
                conexion.CerrarConexion();
                //4 - retornar contenedor con el resultado
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error usuario" + ex.Message);
            }
        }
        public DataTable ListarUsuario()
        {
            DataTable dt = new DataTable();
            try
            {
                //1 - conectar bd
                ejecutarSql.Connection = conexion.AbrirConexion();
                //2 - sacar info de bd
                ejecutarSql.CommandText = "exec dbo.sps_listar_usuarios";
                transaccion = ejecutarSql.ExecuteReader();
                //3 - almacenar data en un contenedor
                dt.Load(transaccion);
                conexion.CerrarConexion();
                //4 - retornar contenedor con el resultado
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error listar usuario" + ex.Message);
            }
        }
        public void InsertarUsuario(Usuario nuevousuario)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText =
                    "insert into ui_usuario(" +
                    "us_nombre, " +
                    "us_apellido, " +
                    "us_identificacion, " +
                    "us_telefono, " +
                    "us_usuario, " +
                    "us_contraseña, " +
                    "us_estado) " +
                    "values('" +
                    nuevousuario.Nombre + "','" +
                    nuevousuario.Apellido + "','" +
                    nuevousuario.Identificacion + "','" +
                    nuevousuario.Telefono + "','" +
                    nuevousuario.UsuarioLogin + "','" +
                    nuevousuario.Contraseña + "','" +
                    nuevousuario.Estado + "')";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar usuario" + ex.Message);
            }
        }
        public void ModificarUsuario(Usuario nuevousuario)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "" +
                    "update ui_usuario set " +
                    "us_nombre = '" + nuevousuario.Nombre + "', " +
                    "us_apellido = '" + nuevousuario.Apellido + "'," +
                    "us_identificacion = '" + nuevousuario.Identificacion + "'," +
                    "us_telefono = '" + nuevousuario.Telefono + "'," +
                    "us_usuario = '" + nuevousuario.UsuarioLogin + "'," +
                    "us_contraseña = '" + nuevousuario.Contraseña + "'," +
                    "us_estado = '" + nuevousuario.Estado + "'" +
                    "where us_id_usuario = '" + nuevousuario.IdUsuario + "'";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar usuario" + ex.Message);
            }
        }
        public void EliminarUsuario(Usuario usuario)
        {
            DataTable dt = new DataTable();
            try
            {
                //1 - conectar bd
                ejecutarSql.Connection = conexion.AbrirConexion();
                //2 - enviar dato a la base
                ejecutarSql.CommandText = "delete from ui_usuario where us_id_usuario = '" + usuario.IdUsuario + "'";
                //3 - ejecutar 
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
                MessageBox.Show("Registro eliminado !!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar, usuario en uso!!");
            }
        }
    }
}
