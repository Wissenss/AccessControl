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
using Middleware;

namespace AccessControl.Catalogos
{
    public partial class FCatalogoPuertas : Form
    {
        public FCatalogoPuertas()
        {
            InitializeComponent();
        }

        private void CaatalogoPuertas_OnLoad(object sender, EventArgs e)
        {
            List<Puerta> puertas;
            Error error = ServiceProvider.Instance.ServicePuertas.GetPuertas(out puertas);
            if (error != Error.NoError)
            {
                MessageBox.Show($"Sucedio el error: {(int)error}, la aplicación intentará continuar...");
                return;
            }
            dtPuertas.Clear();
            dtPuertas.BeginLoadData();
            DataRow row;
            foreach (Puerta puerta in puertas)
            {
                row = dtPuertas.NewRow();

                row["Id"] = puerta.IdPuerta;
                row["Descripcion"] = puerta.Descripcion;
                row["Ubicacion"] = puerta.Ubicacion;
                row["Observaciones"] = puerta.Observaciones;

                dtPuertas.Rows.Add(row);
            }
            dtPuertas.EndLoadData();
        }



        public void EjecutarAccion(object sender, EventArgs e)
        {
            using (FDatosPuerta DDatosPuerta = new FDatosPuerta())
            {
                DDatosPuerta.ShowDialog();
            }
        }
    }
}
