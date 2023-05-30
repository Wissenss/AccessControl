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
    public partial class FCatalogoGruposPuertas : Form
    {
        public FCatalogoGruposPuertas()
        {
            InitializeComponent();
        }

        private void EjecutarAccion(object sender, EventArgs e)
        {
            using(FDatosGrupoPuertas DDatosGrupoPuertas = new FDatosGrupoPuertas())
            {
                DDatosGrupoPuertas.ShowDialog();
            }
        }
    }
}
