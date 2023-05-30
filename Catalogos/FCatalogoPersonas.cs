using AccessControl.Catalogos;
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
    public partial class FCatalogoPersonas : Form
    {
        public FCatalogoPersonas()
        {
            InitializeComponent();
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
