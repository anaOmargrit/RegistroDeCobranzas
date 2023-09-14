using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistroDeCobranzas
{
    public partial class CargarDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter($"{Server.MapPath(".")}/cobranzas.txt", true);
            streamWriter.WriteLine("Nuevo Cobro: ");
            streamWriter.WriteLine(fecha.Text);
            streamWriter.WriteLine(nombre.Text + " " + apellido.Text);
            streamWriter.WriteLine(monto.Text);
            streamWriter.WriteLine("-----");
            streamWriter.Close();
            mensaje1.Text = $"Cobro cargado.";
            mensaje2.Text = $"Ruta del archivo cobranzas.txt: {Server.MapPath(".")}.";
            fecha.Text = string.Empty;
            nombre.Text = string.Empty;
            apellido.Text = string.Empty;
            monto.Text = string.Empty;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}