using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Middleware;
using Middleware.Models;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;

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

        private void FDatosPersona_Load(object sender, EventArgs e)
        {
            if (modo == ModoAcceso.Edicion)
            {
                cargarDatos();
            }
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            Stream file = openFileDialog.OpenFile();
            pbImagen.Image = Image.FromStream(file);
        }

        private void cargarDatos()
        {
            Persona persona;

            Error codigoError = ServiceProvider.Instance.ServicePersonas.GetPersona(personaId, out persona);
            if (codigoError != Error.NoError)
            {
                codigoError.MostrarError();
                return;
            }

            tbNombre.Text = persona.Nombres;
            tbApellidos.Text = persona.Apellidos;
            tbUID.Text = persona.UID;
            tbClave.Text = persona.Clave;
            tbClaveConfirmacion.Text = persona.Clave;
            tbCorreo.Text = persona.Correo;
            tbCelular.Text = persona.Celular;

            if(persona.Imagen != null)
            {
                pbImagen.Image = Image.FromStream(persona.Imagen);
            }
        }

        private void guardarDatos()
        {
            Persona persona = new Persona
            {
                Id = personaId,
                Nombres = tbNombre.Text,
                UID = tbUID.Text,
                Clave = tbClave.Text,
                Apellidos = tbApellidos.Text,
                Correo = tbCorreo.Text,
                Celular = tbCelular.Text,
            };

            persona.Imagen = new MemoryStream();
            pbImagen.Image.Save(persona.Imagen, pbImagen.Image.RawFormat);
            persona.Imagen.Position = 0;

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

            if(!tbClave.Text.Equals(tbClaveConfirmacion.Text))
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
    }
}
