using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControl.Catalogos
{
    public partial class FCatalogoPuertas : Form
    {
        public FCatalogoPuertas()
        {
            InitializeComponent();
        }

        public void EjecutarAccion(object sender, EventArgs e)
        {
            using(FDatosPuerta DDatosPuerta = new FDatosPuerta())
            {
                DDatosPuerta.ShowDialog();
            }
        }
    }
}
