using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ConexionBD
    {
        //1 - Escribir la conexion string de BD.
        private SqlConnection connection = new SqlConnection("Server=Santiago-PC; Database=ui_proyecto; Integrated Security=true");

        //2 - Crear un metodo para abrir la conexion a la BD.
        public SqlConnection AbrirConexion()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }           
            return connection;
        }
        // 3 Método para cerrar la conexión a la base de datos.
        public SqlConnection CerrarConexion()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
