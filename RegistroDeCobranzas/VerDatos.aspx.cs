using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using static RegistroDeCobranzas.VerDatos;


namespace RegistroDeCobranzas
{
    public partial class VerDatos : System.Web.UI.Page
    {
        public class Persona
        {
            public string Fecha;
            public string Nombre;
            public int Monto;
        }

        // aquí se carga la lista de valores mediante la clase persona
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {         
                StreamReader streamReader = new StreamReader(Server.MapPath(".") + "/cobranzas.txt");
                string[] lines = (streamReader.ReadToEnd()).Split('\n');
                streamReader.Close();
                int lineCount = 0;
                int lineRef = 0;

                // obtengo la cantidad de cobros registrados
                foreach (string line in lines)
                {
                    lineCount++;
                    if (lineCount % 5 == 0)
                    {
                        lineRef++;
                    }   
                }                               

                // creo el array y lo cargo con los datos
                Persona[] personas = new Persona[lineRef];
                
                lineCount = 0;
                lineRef = 0;

                foreach (string line in lines)
                {
                    lineCount++;
                    if (lineCount % 5 == 0)
                    {
                        personas[lineRef] = new Persona() {Fecha = $"{lines[lineCount - 4].ToString()}",
                                                           Nombre = $"{lines[lineCount - 3].ToString()}",
                                                           Monto = Convert.ToInt32(lines[lineCount - 2]) };
                        
                        lineRef++;
                    }
                }

                //primero ordeno el array por monto ascendente y luego lo paso por un reverse :)
                Array.Sort(personas, delegate (Persona x, Persona y) { return x.Monto.CompareTo(y.Monto); });
                Array.Reverse(personas);

                // cargo la lista de valores, muestra los datos y como value tiene un número 
                lineCount = 0;
                foreach (Persona p in personas)
                {
                    lineCount++;
                    string fec = p.Fecha;
                    string nom = p.Nombre;
                    int mon = p.Monto;
                    ListItem item = new ListItem();
                    item.Text = $"{fec + " " + nom + " " + mon.ToString()}";
                    item.Value = $"{lineCount}";
                    cobros.Items.Add(item);                    
                }
            }
        }        

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        // al hacer click, muestra los datos del item seleccionado en tres labels diferentes
        protected void Button2_Click(object sender, EventArgs e)
        {
            persona.Text = string.Empty;
            fecha.Text = string.Empty;
            monto.Text = string.Empty;

            StreamReader streamReader = new StreamReader(Server.MapPath(".") + "/cobranzas.txt");
            string[] lines = (streamReader.ReadToEnd()).Split('\n');
            streamReader.Close();
            int lineRef = 0;
            int lineCount = 0;

            // obtengo la cantidad de cobros registrados
            foreach (string line in lines)
            {
                lineCount++;
                if (lineCount % 5 == 0)
                {
                    lineRef++;
                }
            }

            // creo el array y lo cargo con los datos
            Persona[] personas = new Persona[lineRef];

            lineCount = 0;
            lineRef = 0;

            foreach (string line in lines)
            {
                lineCount++;
                if (lineCount % 5 == 0)
                {
                    personas[lineRef] = new Persona()
                    {
                        Fecha = $"{lines[lineCount - 4].ToString()}",
                        Nombre = $"{lines[lineCount - 3].ToString()}",
                        Monto = Convert.ToInt32(lines[lineCount - 2])
                    };

                    lineRef++;
                }
            }

            //primero ordeno el array por monto ascendente y luego lo paso por un reverse :)
            Array.Sort(personas, delegate (Persona x, Persona y) { return x.Monto.CompareTo(y.Monto); });
            Array.Reverse(personas);

            lineCount = 0;
            int opcion = int.Parse(cobros.SelectedItem.Value);            

            foreach (Persona p in personas)
            {
                lineCount++;
                if (lineCount == (opcion))
                {
                    persona.Text += $"Fecha: {p.Fecha.ToString()}";
                    fecha.Text += $"Persona: {p.Nombre.ToString()}";
                    monto.Text += $"Monto: {p.Monto.ToString()}";
                    //comentario//
                }
            }
        }

        // permite limpiar los campos que muestran los datos del cobro seleccionado
        protected void Button3_Click(object sender, EventArgs e)
        {
            persona.Text = string.Empty;
            fecha.Text = string.Empty;
            monto.Text = string.Empty;
        }
    }
}