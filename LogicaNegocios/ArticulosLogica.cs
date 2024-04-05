using AccesoDatos.DAO;
using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaNegocios
{
    public class ArticulosLogica
    {
        private ArticulosDAO articulosDao = new ArticulosDAO();

        public void InsertarArticulo(Articulos cliente)
        {
            articulosDao.InsertarArticulo(cliente);
        }
        public DataTable ListarArticulo()
        {
            return articulosDao.ListarArticulo();
        }
        public void EliminarCliente(Articulos IdCliente)
        {
            articulosDao.EliminarArticulo(IdCliente);
        }
        public void ModificarArticulo(Articulos cliente)
        {
            articulosDao.ModificarArticulo(cliente);
        }
        public List<int> ObtenerAniosExistenes()
        {
            try
            {
                return articulosDao.ObtenerAniosExistenes();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener años existentes: " + ex.Message);
            }
        }
    }
}
