using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccesoDatos.DAO
{
    public class ArticulosDAO
    {
        //1 - Realizar conexion a la BD - Consumir conexion - Crear instancia
        private ConexionBD conexion = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion = null;

        //2 - Crear metodos CRUD
        //2.1 - Metodo Insertar
        public void InsertarArticulo(Articulos nuevoArticulo)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into ui_articulos(" +
                    "in_codigo_articulo, " +
                    "in_descripcion, " +
                    "in_precio_unitario, " +
                    "in_stock, in_estado, " +
                    "in_id_proveedor, " +
                    "in_id_usuario, " +
                    "in_fecha_registro) " +
                    "values('" +
                    nuevoArticulo.CodArticulo + "','" +
                    nuevoArticulo.Descripcion + "','" +
                    nuevoArticulo.Precio.ToString("0.00").Replace(',', '.') + "','" +
                    nuevoArticulo.Stock + "','" +
                    nuevoArticulo.Estado + "','" +
                    nuevoArticulo.IdProveedor + "','" +
                    nuevoArticulo.UsuarioLoginArt + "','" +
                    nuevoArticulo.FechaRegistro + "')";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar articulo" + ex.Message);
            }
        }
        public DataTable ListarArticulo()
        {
            DataTable dt = new DataTable();
            try
            {
                //1 - conectar bd
                ejecutarSql.Connection = conexion.AbrirConexion();
                //2 - sacar info de bd
                ejecutarSql.CommandText = "exec dbo.sps_listar_articulos";
                transaccion = ejecutarSql.ExecuteReader();
                //3 - almacenar data en un contenedor
                dt.Load(transaccion);
                conexion.CerrarConexion();
                //4 - retornar contenedor con el resultado
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar cliente" + ex.Message);
            }
        }
        public void EliminarArticulo(Articulos Cliente)
        {
            DataTable dt = new DataTable();
            try
            {
                //1 - conectar bd
                ejecutarSql.Connection = conexion.AbrirConexion();
                //2 - enviar dato a la base
                ejecutarSql.CommandText = "delete from ui_articulos where in_id_articulo = '" + Cliente.IdArticulo + "'";
                //3 - ejecutar 
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cliente" + ex.Message);
            }
        }
        public void ModificarArticulo(Articulos nuevoCliente)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "update ui_articulos set " +
                    "in_codigo_articulo = '" + nuevoCliente.CodArticulo + "', " +
                    "in_descripcion = '" + nuevoCliente.Descripcion + "'," +
                    "in_precio_unitario = '" + nuevoCliente.Precio.ToString("0.00").Replace(',', '.') + "'," +
                    "in_stock = '" + nuevoCliente.Stock + "'," +
                    "in_estado = '" + nuevoCliente.Estado + "'," +
                    "in_id_proveedor = '" + nuevoCliente.IdProveedor + "'," +
                    "in_fecha_actualizacion = '" + nuevoCliente.FechaActualizacion + "'" +
                    "where in_id_articulo = '" + nuevoCliente.IdArticulo + "'";
                ejecutarSql.ExecuteNonQuery();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar cliente" + ex.Message);
            }
        }
        public List<int> ObtenerAniosExistenes()
        {
            List<int> anios = new List<int>();
            try
            {
                // Conectar con la base de datos
                ejecutarSql.Connection = conexion.AbrirConexion();

                // Realizar la consulta para obtener los años existentes
                ejecutarSql.CommandText = "SELECT DISTINCT YEAR(in_fecha_registro) AS Anio FROM ui_articulos";
                SqlDataReader reader = ejecutarSql.ExecuteReader();

                // Leer los resultados y agregar los años a la lista
                while (reader.Read())
                {
                    int anio = Convert.ToInt32(reader["Anio"]);
                    anios.Add(anio);
                }

                // Cerrar la conexión con la base de datos
                reader.Close();
                conexion.CerrarConexion();

                // Retornar la lista de años
                return anios;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener años existentes: " + ex.Message);
            }
        }        
    }
}
