using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Datos;

namespace Negocio
{
    public class ListaProductos
    {
        private List<ProductoNegocio> listaProductos;
        private Datos.ZapateriaEntities entidades;

        public ListaProductos()
        {
            listaProductos = new List<ProductoNegocio>();
            entidades = new ZapateriaEntities();
        }

        /*public void Llenar()
        {
            listaProductos.Clear();

            foreach(Datos.productos p in entidades.productos)
            {
                ProductoNegocio pro = new ProductoNegocio
                {
                    id = p.id,
                    nombre_producto = p.nombre_producto,
                    descripcion = p.descripcion,
                    precio = p.precio,
                    ultima_modificacion = p.ultima_modificacion
                };
                listaProductos.Add(pro);
            }
        }

        public List<ProductoNegocio> TraerTodo()
        {
            Llenar();
            return listaProductos;
        }*/

        public List<ProductoNegocio> TraerTodo()
        {
            var todos = entidades.productos.ToList();

            foreach(Datos.productos pro in todos)
            {
                ProductoNegocio n = new ProductoNegocio
                {
                    id = pro.id,
                    nombre_producto = pro.nombre_producto,
                    descripcion = pro.descripcion,
                    precio = pro.precio
                };
                listaProductos.Add(n);
            }
            return listaProductos;
        }
    }
}
