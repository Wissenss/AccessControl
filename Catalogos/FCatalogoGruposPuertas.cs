using AccessControl.Models;
using Middleware;
using Middleware.Models;
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
        public static List<GrupoPuerta> gruposPuerta;

        public FCatalogoGruposPuertas()
        {
            InitializeComponent();
        }

        private void GruposPuertas_OnLoad(object sender, EventArgs e)
        {
            Error error = ServiceProvider.Instance.ServicePuertas.GetGruposDePuertas(out gruposPuerta);
            if (error != Error.NoError)
            {
                MessageBox.Show($"Ocurrió el error {(int)error}, la aplicación intentará continuar...");
                return;
            }
            dtGruposPuertas.Clear();
            dtGruposPuertas.BeginLoadData();
            foreach (GrupoPuerta grupo in gruposPuerta)
            {
                DataRow row = dtGruposPuertas.NewRow();
                //Modificar las columnas desde el designer
                row["idGrupo"] = grupo.IdGrupoPuerta;
                row["Nombre"] = grupo.Nombre;
                row["Descripcion"] = grupo.Descripcion;

                dtGruposPuertas.Rows.Add(row);
            }
            dtGruposPuertas.EndLoadData();
        }

        private void EjecutarAccion(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int idGr = Int32.Parse(row.Cells[0].Value.ToString());
            using (FDatosGrupoPuertas DDatosGrupoPuertas = new FDatosGrupoPuertas(idGr))
            {
                DDatosGrupoPuertas.ShowDialog();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
