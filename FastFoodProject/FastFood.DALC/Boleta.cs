//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FastFood.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Boleta
    {
        public int id_boleta { get; set; }
        public string descripcion { get; set; }
        public int pedido_id_pedido { get; set; }
    
        public virtual Pedido Pedido_Boleta { get; set; }
    }
}
