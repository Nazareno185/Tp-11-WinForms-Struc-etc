using Clases;
using Entidades_TP11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1tp1
{
    public partial class FormPersonasSocios : Form
    {
        private Repositorio? repo;
        private List<Personas> listasocios;
        public FormPersonasSocios()
        {
            repo = new Repositorio();
            InitializeComponent();
        }

        private void tbsNuevo_Click(object sender, EventArgs e)
        {
            formSociosAE frm = new formSociosAE() { Text = "Nuevo Socio" };
            DialogResult dr = frm.ShowDialog(this);
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void FormPersonasSocios_Load(object sender, EventArgs e)
        {
            listasocios = repo!.GetSocios();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            dgcDatos.Rows.Clear();
            foreach (var socios in listasocios!) 
            {
                DataGridViewRow r = ConstruirFila(dgcDatos);
                SetearFila(r, socios);
                AgregarFila(r, dgcDatos);
            }
        }

        private void SetearFila(DataGridViewRow r, Personas socios)
        {
            r.Cells[colDNI.Index].Value = socios.Dni;
            
        }

        private void AgregarFila(DataGridViewRow r, DataGridView dgc)
        {
            dgc.Rows.Add(r);
        }

        private DataGridViewRow ConstruirFila(DataGridView dgc)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgc);
            return r;
        }
    }
}
