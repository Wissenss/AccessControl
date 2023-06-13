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
using Middleware.Models;

namespace AccessControl.Catalogos
{
    public partial class FCatalogoPuertas : Form
    {
        List<Puerta> puertas;
        private bool changes = false;
        private List<string[]> taskList;


        public FCatalogoPuertas()
        {
            InitializeComponent();
            taskList = new List<string[]>();
        }

        private void NuevaPuerta()
        {

        }

        private void CaatalogoPuertas_OnLoad(object sender, EventArgs e)
        {
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

        //Editar
        public void EjecutarAccion(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            Puerta seleccionada = puertas[index];
            using (FDatosPuerta DDatosPuerta = new FDatosPuerta(seleccionada))
            {
                var res = DDatosPuerta.ShowDialog();
                if (res == DialogResult.OK)
                {
                    Puerta nuevaPuerta = DDatosPuerta.GetDatosPuerta();
                    int idPuerta = nuevaPuerta.IdPuerta;
                    string Descripcion = nuevaPuerta.Descripcion;
                    string Ubicacion = nuevaPuerta.Ubicacion;
                    string Observaciones = nuevaPuerta.Observaciones;

                    puertas[index] = nuevaPuerta;
                    dataGridView1.Rows[index].SetValues(idPuerta, Descripcion, Ubicacion, Observaciones);
                    this.changes = true;
                    taskList.Add(new string[] { "Update", $"{index}" });
                }
            }
        }

        //Crear
        public void NewPuerta(object sender, EventArgs e)
        {

            using (FDatosPuerta DDatosPuerta = new FDatosPuerta())
            {
                var res = DDatosPuerta.ShowDialog();
                if (res == DialogResult.OK)
                {
                    //obtener datos del DDatosPuerta
                    Puerta nuevaPuerta = DDatosPuerta.GetDatosPuerta();
                    nuevaPuerta.IdPuerta = GetNextId();
                    puertas.Add(nuevaPuerta);

                    DataRow row = dtPuertas.NewRow();
                    row["Id"] = nuevaPuerta.IdPuerta;
                    row["Descripcion"] = nuevaPuerta.Descripcion;
                    row["Ubicacion"] = nuevaPuerta.Ubicacion;
                    row["Observaciones"] = nuevaPuerta.Observaciones;
                    dtPuertas.Rows.Add(row);

                    this.changes = true;
                    taskList.Add(new string[] { "Add", $"{puertas.Count - 1}" });
                }
            }
        }

        //Eliminar
        private void EliminarPuerta(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string idPuerta = row.Cells["ID"].ToString();
            puertas.Remove(puertas[row.Index]);
            taskList.Add(new string[] { "Delete", $"{idPuerta}" });
            this.changes = true;
        }

        //Ejecutar tareas
        private void ExcecuteTasks(object sender, EventArgs e)
        {
            //Lógica para ejecutar la lista de tareas
            if (taskList.Count > 0)
            {
                foreach (string[] task in taskList)
                {
                    int index = Int32.Parse(task[1]);
                    switch (task[0])
                    {
                        case "Delete":
                            ServiceProvider.Instance.ServicePuertas.DeletePuerta(index);
                            break;
                        case "Add":
                            Puerta toSave = puertas[index];
                            ServiceProvider.Instance.ServicePuertas.CreatePuerta(toSave);
                            break;
                        case "Update":
                            Puerta toUpdate = puertas[index];
                            ServiceProvider.Instance.ServicePuertas.UpdatePuerta(toUpdate);
                            break;
                    }
                }
            }
            this.Dispose();
        }

        private int GetNextId()
        {
            int max = Int32.MinValue;
            foreach (Puerta pt in puertas)
            {
                max = (pt.IdPuerta > max) ? pt.IdPuerta : max;
            }
            return max + 1;
        }

    }
}
