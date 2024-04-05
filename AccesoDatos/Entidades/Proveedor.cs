using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Proveedor
    {
       // pr_id_proveedor pr_nombre   pr_identificacion pr_telefono pr_estado
       public int IdProveedor { get; set; }
       public string Nombre { get; set; }
       public string Identificacion { get; set; }
       public string Telefono { get; set; }
       public int Estado { get; set; }

    }
}
