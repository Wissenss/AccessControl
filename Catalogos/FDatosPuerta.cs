using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessControl.Models;

namespace AccessControl.Catalogos
{
    public partial class FDatosPuerta : Form
    {

        private Puerta puertaTemporal;
        public FDatosPuerta()
        {
            InitializeComponent();
            //Si no pasamos ninguna puerta, estamos en modo creativo,
            //por lo tanto, el id será -1 hasta que se genere nuevo, 
            //y no tendrá datos, porque esperará que los llenemos
            this.puertaTemporal = new Puerta(-1, "Sin Asignar", "Sin zona", "Sin Observaciones", -1);
        }

        public FDatosPuerta(Puerta puerta)
        {
            InitializeComponent();
            this.puertaTemporal = puerta;
            this.lbNombrePuerta.Text = puerta.Descripcion;
            this.tbDescripcion.Text = puerta.Descripcion;
            this.tbObservaciones.Text = puerta.Observaciones;
        }

        public Puerta GetDatosPuerta()
        {
            return this.puertaTemporal;
        }

        private bool validateData()
        {
            return (tbDescripcion.Text.Trim() != "");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!validateData())
            {
                MessageBox.Show("El campo Descripción es obligatorio");
                return;
            }
            else
            {
                this.puertaTemporal.Descripcion = tbDescripcion.Text;
                this.puertaTemporal.Observaciones = tbObservaciones.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
