using AccessControl.Models;
using Middleware;
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
    public partial class FCatalogoSemanasTipo : Form
    {
        public FCatalogoSemanasTipo()
        {
            InitializeComponent();
        }

        private void FCatalogoItinerario_Load(object sender, EventArgs e)
        {
            //Termporal, para probar el servicio
            ServiceProvider.Instance.ServiceSemanasTipo.GetSemanasTipo(out List<SemanaTipo> semanas);
            ServiceProvider.Instance.ServiceSemanasTipo.SetSemanaTipo(semanas[0], true);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (FDatosSemanaTipo DDatosItinerario = new FDatosSemanaTipo())
            {
                DDatosItinerario.ShowDialog();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            using (FDatosSemanaTipo DDatosItinerario = new FDatosSemanaTipo())
            {
                DDatosItinerario.ShowDialog();
            }
        }
    }
}
