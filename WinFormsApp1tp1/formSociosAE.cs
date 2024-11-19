
using Clases;
using Entidades_TP11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1tp1
{
    public partial class formSociosAE : Form
    {
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formSociosAE_Load(object sender, EventArgs e)
        {
            //para hacer que el valor de la fecha se a la actual y que no sobre pase los limites
            dtpFechaNc.MaxDate = DateTime.Today.Date;

            //genera un metodo para cargar las "Localidades" en el combo box"
            //usando la referencia del nombre "cbxLocalidad"
            CargarDatosComboLocalidades(ref cbxLocalidad);
        }

        private void CargarDatosComboLocalidades(ref ComboBox cbx)
        {
            //esto trae las localidades enumeradas en la clase localidades
            var localidades = Enum.GetValues(typeof(Localidad));
            cbx.DataSource = localidades;
            cbx.SelectedIndex = 0;
            //para cargarla en el vector "localidades" y ponerlas en el comboBox

            //para que en el comboBox no puedas escribir
            cbx.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos()) 
            {
            
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!validoDni(txtDni.Text)) 
            {
                valido = false;
                errorProvider1.SetError(txtDni, "El DNI es requerido");
            }
            if (string.IsNullOrEmpty(txtPrimerNombre.Text))
            {
                valido = false;
                errorProvider1.SetError(txtPrimerNombre, "Primer nombre es requerido");

            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                valido = false;
                errorProvider1.SetError(txtApellido, "El apellido es requerido");
            }
            return valido;
        }

        private bool validoDni(string dniString)
        {
            if (dniString.Length < 8) 
            {
                return false;
            }
            if (!int.TryParse(dniString, out _)) 
            {
                return false;

            }
            return true;
        }
    }
}
