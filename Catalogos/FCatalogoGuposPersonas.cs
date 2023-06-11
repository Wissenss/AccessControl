using Middleware.Models;
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
    public partial class FCatalogoGuposPersonas : Form
    {
        public FCatalogoGuposPersonas()
        {
            InitializeComponent();
        }
        public static List<GrupoPersona> gruposPersona;
        private void GruposPersonas_OnLoad(object sender, EventArgs e)
        {
            CargarCatalogo();
        }
        private void EjecutarAccion(object sender, EventArgs e)
        {
            using (FDatosGrupoPersonas DGruposPersonas = new FDatosGrupoPersonas())
            {
                if (sender == btnAdd)
                {
                    DGruposPersonas.modo = ModoAcceso.Alta;
                }
                else if (sender == btnEdit && gvListadoGruposPersonas.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = gvListadoGruposPersonas.SelectedRows[0];
                    int grupoPersonaId = (int)row.Cells["IdGrupo"].Value;

                    DGruposPersonas.modo = ModoAcceso.Edicion;
                    DGruposPersonas.grupoPersonasId = grupoPersonaId;
                }
                else
                {
                    return;
                }

                DGruposPersonas.ShowDialog();
            }
            CargarCatalogo();
        }

        private void CargarCatalogo()
        {
            Error error = ServiceProvider.Instance.ServicePersonas.GetGruposDePersonas(out gruposPersona);
            if (error != Error.NoError)
            {
                MessageBox.Show($"Ocurrió el error {(int)error}, la aplicación intentará continuar...");
                return;
            }
            dtGruposPersonas.Clear();
            dtGruposPersonas.BeginLoadData();
            foreach (GrupoPersona grupo in gruposPersona)
            {
                DataRow row = dtGruposPersonas.NewRow();
                //Modificar las columnas desde el designer
                row["idGrupo"] = grupo.idGrupoPersona;
                row["Nombre"] = grupo.Nombre;
                row["Descripcion"] = grupo.Descripcion;

                dtGruposPersonas.Rows.Add(row);
            }
            dtGruposPersonas.EndLoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gvListadoGruposPersonas.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow row = gvListadoGruposPersonas.SelectedRows[0];
            int grupoPersonaId = (int)row.Cells["IdGrupo"].Value;

            Error error = ServiceProvider.Instance.ServicePersonas.DeleteGrupoDePersonas(grupoPersonaId);
            if(error != Error.NoError)
            {
                MessageBox.Show($"Ocurrió el error {(int)error}, la aplicación intentará continuar...");
                return;
            }

            CargarCatalogo();
        }
    }
}
