using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Negocio
{
        [DataObject]
        public class UsuarioCollection
        {
            [DataObjectMethod(DataObjectMethodType.Select)]
            public List<DALC.Usuario> GetUsuarios()
            {
                return CommonBC.ModeloFastFood.Usuario.ToList();
            }

            [DataObjectMethod(DataObjectMethodType.Select)]
            public List<DALC.Usuario> GetUsuariosPorTipo(int id_usuario)
            {
                return CommonBC.ModeloFastFood.Usuario.Where
                    (b => b.id_usuario == id_usuario).ToList();
            }
        }
}
