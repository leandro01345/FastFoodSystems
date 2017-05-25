using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Negocio
{
    public class Pedido
    {
        public int id_pedido;
        public string descripcion;
        public int valor;
        public System.DateTime fecha;
        public string estado;
        public int usuario_id_usuario;

        public Pedido()
        {
            this.Init();
        }
        private void Init()
        {

            id_pedido = 0;
            descripcion = string.Empty;
            fecha = DateTime.Now;
            valor = 0;
            estado = string.Empty;
            usuario_id_usuario = 0;

        }

        //Metodos CRUD
        public bool Read()
        {
            try
            {
                DALC.Pedido ped = CommonBC.ModeloFastFood.Pedido.First(pedid => pedid.id_pedido == id_pedido);
                id_pedido = ped.id_pedido;
                descripcion = ped.descripcion;
                fecha = ped.fecha;
                this.valor = ped.valor;
                estado = ped.estado;
                usuario_id_usuario = ped.usuario_id_usuario;
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
                DALC.Pedido p = new DALC.Pedido();
                p.id_pedido = id_pedido;
                p.descripcion = descripcion;
                p.fecha = fecha;
                p.valor = valor;
                p.estado = estado;
                p.usuario_id_usuario = p.usuario_id_usuario;

                CommonBC.ModeloFastFood.Pedido.Add(p);
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
                DALC.Pedido p = CommonBC.ModeloFastFood.Pedido.First(x => x.id_pedido == id_pedido);
                p.id_pedido = id_pedido;
                p.descripcion = descripcion;
                p.fecha = fecha;
                p.valor = valor;
                p.estado = estado;
                p.usuario_id_usuario = p.usuario_id_usuario;

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
                DALC.Pedido prod = CommonBC.ModeloFastFood.Pedido.First(p => p.id_pedido == id_pedido);

                CommonBC.ModeloFastFood.Pedido.Remove(prod);
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
