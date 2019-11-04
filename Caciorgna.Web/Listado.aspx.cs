using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Caciorgna.Negocio;
using Caciorgna.Entidades;

namespace Caciorgna.Web
{
    public partial class Listado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Entidades.TipoPersona> tiposPersonas = new List<Entidades.TipoPersona>();
            tiposPersonas = Negocio.TipoPersona.RecuperarTodos();


            foreach (Entidades.TipoPersona tipoPer in tiposPersonas)
            {
                ddlTipoPersona.Items.Add(tipoPer.Id.ToString());
            }

        
        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            
            int itemSeleccionado = Int32.Parse(ddlTipoPersona.SelectedValue);

            cargarGrillaPorTipoPersona(itemSeleccionado);

        }

        

        private void cargarGrillaPorTipoPersona(int itemSeleccionado)
        {
             
        }

    }
}