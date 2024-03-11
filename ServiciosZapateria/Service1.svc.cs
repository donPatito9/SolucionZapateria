using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Negocio;

namespace ServiciosZapateria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public bool IngresarProducto(int id, string nombre_producto, string descripcion, int precio)
        {
            bool res = false;

            try
            {
                ProductoNegocio productoNegocio = new ProductoNegocio
                {
                    id = id,
                    nombre_producto = nombre_producto,
                    descripcion = descripcion,
                    precio = precio
                };
                if(productoNegocio.Create())
                    res = true;
            }
            catch(Exception)
            {
                res = false;
            }
            return res;
        }

        public bool Validar(string usuario, string contrasenna)
        {
            bool res = false;

            UsuarioNegocio usu = new UsuarioNegocio();

            usu.usuario = usuario;
            usu.contrasenna = contrasenna;

            res = usu.Validar();

            return res;
        }

        ListaProductos lista;

        public List<ProductoNegocio> TraerTodo()
        {
            lista = new ListaProductos();
            return lista.TraerTodo();
        }
    }
}
