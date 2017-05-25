using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastFood.DALC;


namespace FastFood.Negocio
{
    class CommonBC
    {
        private static FastFoodEntities _modeloFastFood;
        public static FastFoodEntities ModeloFastFood
        {
            get
            {
                if (_modeloFastFood == null)
                {
                    _modeloFastFood = new FastFoodEntities();
                }
                return _modeloFastFood;
            }
        }

        public CommonBC() { }
    }
}
