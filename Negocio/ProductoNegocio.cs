using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Datos;

namespace Negocio
{
    public class ProductoNegocio
    {
        public int id { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
        public string ultima_modificacion { get; set; }

        private ZapateriaEntities entidades;

        public ProductoNegocio()
        {
            entidades = new ZapateriaEntities();
        }

        public bool Create()
        {
            bool res = false;
            try
            {
                productos pro = new productos
                {
                    id = this.id,
                    nombre_producto = this.nombre_producto,
                    descripcion = this.descripcion,
                    precio = this.precio
                };

                entidades.productos.Add(pro);
                entidades.SaveChanges();
                res = true;
            }
            catch(System.Data.UpdateException)
            {
                throw new Exception("No se pueden ingresar los datos");
            }
            return res;
        }
    }
}
