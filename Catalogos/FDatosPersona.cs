using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Middleware;
using Middleware.Models;

namespace AccessControl.Catalogos
{
    public partial class FDatosPersona : Form
    {
        //aqui se asume que modo y persona son variables que se asignan en la creacion, antes del evento Load
        public ModoAcceso modo; 
        public int personaId;

        public FDatosPersona()
        {
            InitializeComponent();
        }

        //supongo que si tendria sentido para ahorarte la consulta extra
        //aunque puede haber datos que no necesariamente mandes al listado
        //y solo los regreses a la hora de consultar para optimizar,
        //aunque tampoco creo que lleguemos a ese punto, la verdad no se que sea mejor...
        //public FDatosPersona(string[] personData)
        //{
        //    InitializeComponent();
        //}

        private void FDatosPersona_Load(object sender, EventArgs e)
        {
            if (modo == ModoAcceso.Edicion)
            {
                cargarDatos();
            }
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void cargarDatos()
        {
            Persona persona;

            Error codigoError = ServiceProvider.Instance.ServicePersonas.GetPersona(personaId, out persona);
            if (codigoError != Error.NoError)
            {
                MessageBox.Show("Sucedió el error: " + (int)codigoError + " la aplicación intentará continuar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbNombre.Text = persona.Nombres;
            tbApellidos.Text = persona.Apellidos;
            tbCorreo.Text = persona.Correo;
            tbCelular.Text = persona.Celular;
        }

        private void guardarDatos()
        {
            Persona persona = new Persona
            {
                Id = personaId,
                Nombres = tbNombre.Text,
                Apellidos = tbApellidos.Text,
                Correo = tbCorreo.Text,
                Celular = tbCelular.Text
            };

            Error codigoError = ServiceProvider.Instance.ServicePersonas.SetPersona(persona, modo == ModoAcceso.Alta);
            if (codigoError != Error.NoError)
            {
                MessageBox.Show("Sucedió el error: " + (int)codigoError + " la aplicación intentará continuar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool validarDatos()
        {
            //PENDIENTE, esta validacion no es gran cosa por decir lo menos...
            if (tbNombre.Text.Trim().Length == 0)
                return false;
            if (tbApellidos.Text.Trim().Length == 0)
                return false;

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                MessageBox.Show("Datos inválidos o incompletos, revise la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            guardarDatos();

            DialogResult = DialogResult.OK;
        }

        //graficos
        private void cbRol_DrawItem(object sender, DrawItemEventArgs e) //para que el combobox tenga el hightlight morado
        {
            var combo = sender as ComboBox;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(90, 76, 151)), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlLightLight), e.Bounds);
            }

            e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                          e.Font,
                                          new SolidBrush(Color.Black),
                                          new Point(e.Bounds.X, e.Bounds.Y));
        }
    }
}
