using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Negocio
{
    [DataObject]
    public class ProductoCollection
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<DALC.Producto> GetProductos()
        {
            return CommonBC.ModeloFastFood.Producto.ToList();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<DALC.Producto> GetProductosPorTipo(int id_producto)
        {
            return CommonBC.ModeloFastFood.Producto.Where
                (b => b.id_producto == id_producto).ToList();
        }
    }
}
