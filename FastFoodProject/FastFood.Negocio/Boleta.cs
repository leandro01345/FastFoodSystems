using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Negocio
{
    class Boleta
    {
        public int id_boleta;
        public string descripcion;
        public int pedido_id_pedido;

        public Boleta()
        {
            this.Init();
        }
        private void Init()
        {
            this.id_boleta = 0;
            descripcion = string.Empty;
            pedido_id_pedido = 0;

        }

        //Metodos CRUD
        public bool Read()
        {
            try
            {
                DALC.Boleta boleta = CommonBC.ModeloFastFood.Boleta.First(bol => bol.id_boleta == id_boleta);
                id_boleta = boleta.id_boleta;
                descripcion = boleta.descripcion;
                pedido_id_pedido = boleta.pedido_id_pedido;
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
                DALC.Boleta bol = new DALC.Boleta();
                bol.id_boleta = id_boleta;
                bol.descripcion = descripcion;
                bol.pedido_id_pedido = pedido_id_pedido;
               

                CommonBC.ModeloFastFood.Boleta.Add(bol);
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
                DALC.Boleta bol = CommonBC.ModeloFastFood.Boleta.First(x => x.id_boleta == id_boleta);
                bol.id_boleta = id_boleta;
                bol.descripcion = descripcion;
                bol.pedido_id_pedido = pedido_id_pedido;

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
                DALC.Boleta bol = CommonBC.ModeloFastFood.Boleta.First(p => p.id_boleta == id_boleta);

                CommonBC.ModeloFastFood.Boleta.Remove(bol);
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
