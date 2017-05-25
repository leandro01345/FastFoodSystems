using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Negocio
{

        [DataObject]
        public class PedidoCollection
        {
            [DataObjectMethod(DataObjectMethodType.Select)]
            public List<DALC.Pedido> GetPedidos()
            {
                return CommonBC.ModeloFastFood.Pedido.ToList();
            }

            [DataObjectMethod(DataObjectMethodType.Select)]
            public List<DALC.Pedido> GetPedidosPorTipo(int id_pedido)
            {
                return CommonBC.ModeloFastFood.Pedido.Where
                    (b => b.id_pedido == id_pedido).ToList();
            }
        }
}
