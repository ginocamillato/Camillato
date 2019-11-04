using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caciorgna.Entidades;
using Caciorgna.Negocio;

namespace Caciorgna.Escritorio
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
                List<Entidades.TipoPersona> tiposPersona = new List<Entidades.TipoPersona>();
            tiposPersona = Negocio.TipoPersona.RecuperarTodos();

            foreach (Entidades.TipoPersona tipoPersona in tiposPersona)
            {
                cmbTipoPersona.Items.Add(tipoPersona.Id);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DateTime fecha_nac = DateTime.Parse(txtFechaNacimiento.Text);
            Entidades.Persona persona = new Entidades.Persona();
            

            persona.Apellido = txtApellido.Text;
            persona.Nombre = txtNombre.Text;
            persona.Email = txtEmail.Text;
            persona.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            persona.Tipo_Persona = Int32.Parse(cmbTipoPersona.SelectedItem.ToString());


            if (txtApellido.Text != null && txtNombre.Text != null &&  cmbTipoPersona.SelectedItem.ToString() !=null && txtEmail.Text != null && txtFechaNacimiento.Text != null)
            {
                if (Validaciones.EsFechaNacimientoValida(fecha_nac))
                {
                    Negocio.Persona.Agregar(persona);
                    MessageBox.Show("Se ha ingresado a la persona de manera correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fecha de nacimiento invalida", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
