using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Negocio
{
    public class Producto
    {
        public int id_producto;
        public string nombre;
        public int cantidad;
        public int valor;
        public Nullable<int> pedido_id_pedido;

        public Producto()
        {
            this.Init();
        }
        private void Init()
        {

            id_producto = 0;
            nombre = string.Empty;
            cantidad = 0;
            valor = 0;
            pedido_id_pedido = 0;

        }

        //Metodos CRUD
        public bool Read()
        {
            try
            {
                DALC.Producto user = CommonBC.ModeloFastFood.Producto.First(userx => userx.id_producto == id_producto);
                id_producto = user.id_producto;
                nombre = user.nombre;
                cantidad = user.cantidad;
                valor = user.valor;
                pedido_id_pedido = user.pedido_id_pedido;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Create()
        {
            try
            {
                DALC.Producto p = new DALC.Producto();
                p.id_producto = id_producto;
                p.nombre = nombre;
                p.cantidad = cantidad;
                p.valor = valor;
                p.pedido_id_pedido = pedido_id_pedido;

                CommonBC.ModeloFastFood.Producto.Add(p);
                CommonBC.ModeloFastFood.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update()
        {
            try
            {
                DALC.Producto p = CommonBC.ModeloFastFood.Producto.First(x => x.id_producto == id_producto);
                p.id_producto = id_producto;
                p.nombre = nombre;
                p.cantidad = cantidad;
                p.valor = valor;
                p.pedido_id_pedido = pedido_id_pedido;

                CommonBC.ModeloFastFood.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                DALC.Producto prod = CommonBC.ModeloFastFood.Producto.First(p => p.id_producto == id_producto);

                CommonBC.ModeloFastFood.Producto.Remove(prod);
                CommonBC.ModeloFastFood.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
