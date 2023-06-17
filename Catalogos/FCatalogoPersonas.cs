using AccessControl.Catalogos;
using Middleware;
using Middleware.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AccessControl
{
    public partial class FCatalogoPersonas : Form
    {
        public List<int> PersonasSeleccionadas;

        public ModoAcceso modo = ModoAcceso.Edicion;

        public FCatalogoPersonas()
        {
            InitializeComponent();
        }
        private void FCatalogoPersonas_Load(object sender, EventArgs e)
        {
            if(modo == ModoAcceso.Seleccion)
            {
                btnCancel.Text = "Cancelar";
                BtnSelect.Visible = true;
                btnAccept.Visible = false;
                btnAdd.Visible = false;
                btnEdit.Visible = false;
                BtnEliminar.Visible = false;
            }

            cargarPersonas();
        }

        //esta funcion se encarga de las funciones de editar y agregar
        public void EjecutarAccion(object sender, EventArgs e)
        {
            using(FDatosPersona DDatosPersona = new FDatosPersona())
            {
                if(sender == btnAdd)
                {
                    DDatosPersona.modo = ModoAcceso.Alta;
                }
                else if (sender == btnEdit && gvListadoPersonas.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = gvListadoPersonas.SelectedRows[0];
                    int personaId = (int)row.Cells["colId"].Value;

                    DDatosPersona.modo = ModoAcceso.Edicion;
                    DDatosPersona.personaId = personaId;
                }
                else
                {
                    return;
                }
                
                DDatosPersona.ShowDialog();
            }
            cargarPersonas();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (gvListadoPersonas.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = this.gvListadoPersonas.SelectedRows[0];
            int personaId = (int)row.Cells["colId"].Value;

            Error codigoError = ServiceProvider.Instance.ServicePersonas.DeletePersona(personaId);
            if (codigoError != Error.NoError)
            {
                MessageBox.Show("Sucedió el error: " + (int)codigoError + " la aplicación intentará continuar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cargarPersonas(); 
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (gvListadoPersonas.SelectedRows.Count == 0)
                return;

            List<int> personas = new List<int>();
            foreach(DataGridViewRow row in gvListadoPersonas.SelectedRows)
            {
                personas.Add((int)row.Cells["colId"].Value);
            }

            this.PersonasSeleccionadas = personas;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cargarPersonas() //medio savage cargar todas las personas (llamar a esta funcion) en casos donde solo cambia uno de los registros pero weno, de 0.00001 a 0.00002ms no se nota
        {
            List<Persona> personas;
            Error codigoError = ServiceProvider.Instance.ServicePersonas.GetPersonas(out personas);
            if (codigoError != Error.NoError)
            {
                MessageBox.Show("Sucedió el error: " + (int)codigoError + " la aplicación intentará continuar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dtPersonas.Clear();
            dtPersonas.BeginLoadData();
            DataRow register;
            foreach (Persona persona in personas)
            {
                register = dtPersonas.NewRow();

                register["Id"] = persona.Id;
                register["Nombre"] = persona.Nombres;

                dtPersonas.Rows.Add(register);
            }
            dtPersonas.EndLoadData();
        }

        private void tbSearchText_TextChanged(object sender, EventArgs e)
        {
            string filter;

            if (tbSearchText.Text.Equals(" Ingrese el texto a buscar...") || tbSearchText.Text.Trim().Length == 0) //esto significa que esta vacio
            {
                filter = null;
            }
            else
            {
                string searchParam = tbSearchText.Text;
                filter = string.Format("convert(Id, 'System.String') Like '{0}%' OR Nombre Like '%{0}%'", searchParam);
            }

            bindingSource1.Filter = filter;
        }

        private void tbSearchText_Leave(object sender, EventArgs e)
        {
            if (tbSearchText.Text.Trim().Length == 0)
            {
                tbSearchText.Text = " Ingrese el texto a buscar...";
            }

            tbSearchText.ForeColor = SystemColors.GrayText;
        }

        private void tbSearchText_Enter(object sender, EventArgs e)
        {
            if (tbSearchText.Text.Equals(" Ingrese el texto a buscar..."))
            {
                tbSearchText.Text = "";
            }

            tbSearchText.ForeColor = SystemColors.WindowText;
        }
    }
}
