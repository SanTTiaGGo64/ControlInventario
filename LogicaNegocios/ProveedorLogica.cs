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
    public class ProveedorLogica
    {
        private ProveedorDAO proveedorDao = new ProveedorDAO();
        public DataTable ListarProveedor()
        {
            return proveedorDao.ListarProveedor();
        }
        public void InsertarProveedor(Proveedor proveedor)
        {
            proveedorDao.InsertarProveedor(proveedor);
        }
        public void EliminarProveedor(Proveedor IdProveedor)
        {
            proveedorDao.EliminarProveedor(IdProveedor);
        }
        public void ModificarProveedor(Proveedor IdProveedor)
        {
            proveedorDao.ModificarProveedor(IdProveedor);
        }
    }
}
