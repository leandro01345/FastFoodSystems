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
        public List<DALC.Producto> GetProductosPorPedido(int id_pedido)
        {
            return CommonBC.ModeloFastFood.Producto.Where
                (b => b.pedido_id_pedido == id_pedido).ToList();
        }
    }
}
