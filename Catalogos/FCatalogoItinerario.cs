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
    public partial class FCatalogoItinerario : Form
    {
        public FCatalogoItinerario()
        {
            InitializeComponent();
        }

        private void FCatalogoItinerario_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (FDatosItinerario DDatosItinerario = new FDatosItinerario())
            {
                DDatosItinerario.ShowDialog();
            }
        }
    }
}
