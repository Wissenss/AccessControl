using AccessControl.Catalogos;
using Middleware;
using Middleware.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControl
{
    public partial class FDatosGrupoPersonas : Form
    {
        public int grupoPersonasId { get; set; }
        public ModoAcceso modo { get; set; }

        public FDatosGrupoPersonas()
        {
            InitializeComponent();
        }
        private void FDatosGrupoPersonas_Load(object sender, EventArgs e)
        {
            List<Persona> personas;
            Error codigoError = ServiceProvider.Instance.ServicePersonas.GetPersonas(out personas);
            if (codigoError != Error.NoError)
            {
                MessageBox.Show($"Ocurrió el error {(int)codigoError}, la aplicación intentará continuar...");
                return;
            }

            if (modo == ModoAcceso.Edicion)
            {
                CargarDatos();
            }
            else
            {
                NuevosDatos();
            }

            ActualizarControlesActivos();
        }

        private void CargarDatos()
        {
            GrupoPersona grupo;
            Error codigoError;
            
            codigoError = ServiceProvider.Instance.ServicePersonas.GetGrupoDePersonas(grupoPersonasId, out grupo);
            if(codigoError != Error.NoError)
            {
                MessageBox.Show($"Ocurrió el error {(int)codigoError}, la aplicación intentará continuar...");
                return;
            }

            tbNombre.Text = grupo.Nombre;
            tbDescripcion.Text = grupo.Descripcion;

            //this.Miembros = grupo.personas;
            //lbMiembros.DataSource = this.Miembros;
            //lbMiembros.DisplayMember = "Nombres";
            //lbMiembros.ValueMember = "Id";

            List<Persona> personas;
            codigoError = ServiceProvider.Instance.ServicePersonas.GetPersonas(out personas);
            if (codigoError != Error.NoError)
            {
                MessageBox.Show($"Ocurrió el error {(int)codigoError}, la aplicación intentará continuar...");
                return;
            }

            //this.Personas = personas.RemoveAll(item => grupo.personas.Any(item2 => item.Id == item2.Id));
            //this.Personas = personas.Except(grupo.personas).ToList(); //remueve todos las personas que ya son miembros del grupo

            //foreach(Persona persona in grupo.personas)
            //{
            //    personas.Remove(persona);
            //}


            bool esMiembro = false;
            foreach(Persona persona in personas)
            {
                foreach(Persona miembro in grupo.personas)
                {
                    if(persona.Id == miembro.Id)
                    {
                        esMiembro = true;
                        break;
                    }
                    esMiembro = false;
                }

                if (esMiembro)
                {
                    lbMiembros.Items.Add(persona);
                }
                else
                {
                    lbPersonas.Items.Add(persona);
                }
            }

            //this.Personas = personas;
            //lbPersonas.DataSource = this.Personas;
            //lbPersonas.DisplayMember = "Nombres";
            //lbPersonas.ValueMember = "Id";
        }

        private void NuevosDatos()
        {
            List<Persona> personas;
            Error codigoError = ServiceProvider.Instance.ServicePersonas.GetPersonas(out personas);
            if (codigoError != Error.NoError)
            {
                MessageBox.Show($"Ocurrió el error {(int)codigoError}, la aplicación intentará continuar...");
                return;
            }

            foreach (Persona persona in personas)
            {
                lbPersonas.Items.Add(persona);
            }
        }

        private bool ValidarDatos()
        {
            if (lbMiembros.Items.Count == 0)
                return false;
            if (tbNombre.Text.Trim().Length == 0)
                return false;
            if (tbDescripcion.Text.Trim().Length == 0)
                return false;

            return true;
        }

        private void GuardarDatos()
        {
            GrupoPersona grupo = new GrupoPersona
            {
                idGrupoPersona = grupoPersonasId, 
                Nombre = tbNombre.Text,
                Descripcion = tbDescripcion.Text
            };

            foreach(Persona miembro in lbMiembros.Items)
            {
                grupo.AñadirPersona(miembro);
            }

            Error codigoError = ServiceProvider.Instance.ServicePersonas.SetGrupoDePersonas(grupo, modo == ModoAcceso.Alta);
            if (codigoError != Error.NoError)
            {
                MessageBox.Show($"Ocurrió el error {(int)codigoError}, la aplicación intentará continuar...");
                return;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(!ValidarDatos())
            {
                MessageBox.Show("Datos inválidos o incompletos, revise la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GuardarDatos();
            DialogResult = DialogResult.OK;
        }

        //graficos y comportamiento de los controles
        private void BtnAddSelected_Click(object sender, EventArgs e)
        {
            while(lbPersonas.SelectedItems.Count > 0)
            {
                Persona item = (Persona)lbPersonas.SelectedItems[0];

                lbMiembros.Items.Add(item);
                lbPersonas.Items.Remove(item);
            }
            ActualizarControlesActivos();
        }

        private void BtnRemoveSelected_Click(object sender, EventArgs e)
        {
            while (lbMiembros.SelectedItems.Count > 0)
            {
                Persona item = (Persona)lbMiembros.SelectedItems[0];
                lbPersonas.Items.Add(item);
                lbMiembros.Items.Remove(item);
            }
            ActualizarControlesActivos();
        }

        private void BtnAddAll_Click(object sender, EventArgs e)
        {
            while (lbPersonas.Items.Count > 0)
            {
                Persona item = (Persona)lbPersonas.Items[0];
                lbMiembros.Items.Add(item);
                lbPersonas.Items.Remove(item);
            }
            ActualizarControlesActivos();
        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            while (lbMiembros.Items.Count > 0)
            {
                Persona item = (Persona)lbMiembros.Items[0];
                lbPersonas.Items.Add(item);
                lbMiembros.Items.Remove(item);
            }
            ActualizarControlesActivos();
        }

        private void ActualizarControlesActivos()
        {
            BtnAddSelected.Enabled = lbPersonas.SelectedItems.Count > 0; 
            BtnRemoveSelected.Enabled = lbMiembros.SelectedItems.Count > 0;
            BtnAddAll.Enabled = lbPersonas.Items.Count > 0;
            BtnRemoveAll.Enabled = lbMiembros.Items.Count > 0;
        }

        private void DrawItemSelected(object sender, DrawItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;

            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.FromArgb(90, 76, 151));

            e.DrawBackground();
            e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void On_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarControlesActivos();
        }

    }
}
