using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWebZapateria
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            lblSaludo.Text ="Bienvenido " + Context.User.Identity.Name;
        }

        protected void btnProductos_Click(object sender, EventArgs e)
        {
            ServiciosZapateria.Service1Client producto = new ServiciosZapateria.Service1Client();

            gvProductos.DataSource = producto.TraerTodo();
            gvProductos.DataBind();
        }
    }
}