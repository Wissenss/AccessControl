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
            List<Persona> personas;
            Error codigoError = ServiceProvider.Instance.ServicePersonas.GetPersonas(out personas);
            if(codigoError != Error.NoError)
            {
                MessageBox.Show("Sucedio el error: " + (int)codigoError + " la aplicacion intentara continuar...");
                return;
            }

            dtPersonas.Clear();
            dtPersonas.BeginLoadData();
            DataRow register;
            foreach(Persona persona in personas)
            {
                register = dtPersonas.NewRow();

                register["Id"] = persona.Id;
                register["Nombre"] = persona.Nombres;

                dtPersonas.Rows.Add(register);
            }
            dtPersonas.EndLoadData();
        }

        //esta funcion se encarga de las funciones de edicion, eliminar y agregar
        public void EjecutarAccion(object sender, EventArgs e)
        {
            using(FDatosPersona DDatosPersona = new FDatosPersona())
            {
                DDatosPersona.ShowDialog();
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }
    }
}
