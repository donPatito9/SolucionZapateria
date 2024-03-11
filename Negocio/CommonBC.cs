using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    class CommonBC
    {
        private static ZapateriaEntities _modeloZapateria;
        public static ZapateriaEntities ModeloZapateria
        {
            get
            {
                if(_modeloZapateria == null)
                {
                    _modeloZapateria = new ZapateriaEntities();
                }
                return _modeloZapateria;
            }
        }

        public CommonBC()
        {

        }
    }
}
