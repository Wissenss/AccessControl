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
        public FCatalogoGruposPuertas()
        {
            InitializeComponent();
        }

        private void GruposPuertas_OnLoad(object sender, EventArgs e)
        {
            List<GrupoPuerta> gruposPuerta;
            Error error = ServiceProvider.Instance.ServicePuertas.GetGruposDePuertas(out gruposPuerta); 
            if(error != Error.NoError)
            {
                MessageBox.Show($"Ocurrió el error {(int)error}, la aplicación intentará continuar...");
                return;
            }
            dtGruposPuertas.Clear();
            dtGruposPuertas.BeginLoadData();
            foreach(GrupoPuerta grupo in gruposPuerta)
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
            using(FDatosGrupoPuertas DDatosGrupoPuertas = new FDatosGrupoPuertas())
            {
                DDatosGrupoPuertas.ShowDialog();
            }
        }
    }
}
