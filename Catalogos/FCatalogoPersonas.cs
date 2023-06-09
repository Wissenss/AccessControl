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
        public FCatalogoPersonas()
        {
            InitializeComponent();
        }
        private void FCatalogoPersonas_Load(object sender, EventArgs e)
        {
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
                    DataGridViewRow row = this.gvListadoPersonas.SelectedRows[0];
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
            //PENDIENTE...
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //PENDIENTE...
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void cargarPersonas() //medio savage cargar todas las personas cuando solo cambia uno de los registros pero weno, de 0.00001 a 0.00002ms no se nota
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
    }
}
