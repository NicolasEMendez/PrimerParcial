using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.Dominio
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public TipoCategoria TipoCategoria { get; set; }
        public Inventario Inventario { get; set; }
        public Facturacion Facturacion { get; set; }

        public void SetearIdProducto(int idProducto)
        {
            IdProducto = idProducto;
        }

        public int MostrarProducto()
        {
            return IdProducto;
        }
    }
}
