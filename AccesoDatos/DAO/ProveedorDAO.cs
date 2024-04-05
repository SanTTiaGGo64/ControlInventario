using AccesoDatos.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccesoDatos.DAO
{
    public class ProveedorDAO
    {
        //1 - Realizar conexion a la BD - Consumir conexion - Crear instancia
        private ConexionBD conexion = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion = null;
        public DataTable ListarProveedor()
        {
            DataTable dt = new DataTable();
            try
            {
                //1 - conectar bd
                ejecutarSql.Connection = conexion.AbrirConexion();
                //2 - sacar info de bd
                ejecutarSql.CommandText = "exec dbo.sps_listar_proveedor";
                transaccion = ejecutarSql.ExecuteReader();
                //3 - almacenar data en un contenedor
                dt.Load(transaccion);
                conexion.CerrarConexion();
                //4 - retornar contenedor con el resultado
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar proveedor" + ex.Message);
            }
        }
        public void InsertarProveedor(Proveedor nuevoProveedor)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into ui_proveedor(pr_nombre, pr_identificacion, pr_telefono, pr_estado) values('" + nuevoProveedor.Nombre + "','" + nuevoProveedor.Identificacion + "','" + nuevoProveedor.Telefono + "','" + nuevoProveedor.Estado + "')";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar proveedor" + ex.Message);
            }
        }
        public void EliminarProveedor(Proveedor proveedor)
        {
            DataTable dt = new DataTable();
            try
            {
                //1 - conectar bd
                ejecutarSql.Connection = conexion.AbrirConexion();
                //2 - enviar dato a la base
                ejecutarSql.CommandText = "delete from ui_proveedor where pr_id_proveedor = '" + proveedor.IdProveedor + "'";
                //3 - ejecutar 
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
                MessageBox.Show("Registro eliminado !!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar, proveedor esta asignado a un articulo !!");
            }
        }
        public void ModificarProveedor(Proveedor nuevoProveedor)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "" +
                    "update ui_Proveedor set " +
                    "pr_nombre = '" + nuevoProveedor.Nombre + "', " +
                    "pr_identificacion = '" + nuevoProveedor.Identificacion + "'," +
                    "pr_telefono = '" + nuevoProveedor.Telefono + "'," +
                    "pr_estado = '" + nuevoProveedor.Estado + "'" +
                    "where pr_id_proveedor = '" + nuevoProveedor.IdProveedor + "'";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar cliente" + ex.Message);
            }
        }
    }
}
