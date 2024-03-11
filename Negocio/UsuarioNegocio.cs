using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.Entity;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public string usuario { get; set; }
        public string contrasenna { get; set; }
        public string nombre_usuario { get; set; }

        private ZapateriaEntities entidades;

        public UsuarioNegocio()
        {
            entidades = new ZapateriaEntities();
        }

        public bool Validar()
        {
            bool res = false;

            Datos.usuarios usu = entidades.usuarios.FirstOrDefault(
                p => p.usuario == this.usuario && p.contrasenna == this.contrasenna);

            if(usu != null)
                res = true;

            return res;
        }
    }
}
