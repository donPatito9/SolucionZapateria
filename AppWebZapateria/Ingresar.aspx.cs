using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace AppWebZapateria
{
    public partial class Ingresar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                ServiciosZapateria.Service1Client productoServicio =
                    new ServiciosZapateria.Service1Client();

                if (productoServicio.IngresarProducto(int.Parse(txtId.Text), txtNombre.Text, txtDescripcion.Text, int.Parse(txtPrecio.Text)))
                {
                    Response.Redirect("Inicio.aspx");
                }
                else
                {
                    lblMensaje.Text = "No se ha podido agregar el producto";
                }
            }
            catch(Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }
    }
}