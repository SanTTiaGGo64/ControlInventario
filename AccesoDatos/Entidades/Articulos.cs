using System;

namespace AccesoDatos.Entidades
{
    public class Articulos
    {
        //Los datos que se tiene en la base de datos
        public int IdArticulo { get; set; }
        public string CodArticulo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int Estado { get; set; }
        public int IdProveedor { get; set; }
        public int UsuarioLoginArt { get; set; }
        public string FechaRegistro { get; set; }
        public string FechaActualizacion { get; set; }
        //Registros no se borran de la base, se cambian de estar a eliminado y no se muestra al cliente
    }
}
