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
        private List<SemanaTipo> listSemanasTipos;
        private List<string[]> taskList;
        private bool changes = false;
        public FCatalogoSemanasTipo()
        {
            InitializeComponent();
        }


        private void FCatalogoItinerario_Load(object sender, EventArgs e)
        {
            ServiceProvider.Instance.ServiceSemanasTipo.GetSemanasTipo(out listSemanasTipos);
            dtSemanasTipo.Clear();
            dtSemanasTipo.BeginLoadData();
            DataRow row;
            foreach (SemanaTipo semana in listSemanasTipos)
            {
                row = dtSemanasTipo.NewRow();
                row["Id"] = semana.IdSemanaTipo;
                row["Nombre"] = semana.Descripcion;
                dtSemanasTipo.Rows.Add(row);
            }
            dtSemanasTipo.EndLoadData();
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
            int index = dataGridView1.SelectedRows[0].Index;

            using (FDatosSemanaTipo DDatosItinerario = new FDatosSemanaTipo(listSemanasTipos[index]))
            {
                DDatosItinerario.ShowDialog();
            }
        }
    }
}
