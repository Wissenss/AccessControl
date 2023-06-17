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
        public ModoAcceso modo = ModoAcceso.Edicion;
        public List<int> puertasSeleccion;

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
            if(modo == ModoAcceso.Seleccion)
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                BtnSelect.Visible = true;
            }

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
                    taskList.Add(new string[] { "Update", $"{index}", $"{idPuerta}" });
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
                    taskList.Add(new string[] { "Add", $"{puertas.Count - 1}", $"{nuevaPuerta.IdPuerta}" });
                }
            }
        }

        //Eliminar
        private void EliminarPuerta(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;

            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string idPuerta = row.Cells[0].Value.ToString();
            taskList.Add(new string[] { "Delete", $"{idPuerta}" });
            puertas.Remove(puertas[row.Index]);
            dataGridView1.Rows.Remove(row);
            for(int i = 0; i<taskList.Count; i++)
            {
                if ((taskList[i][0] == "Add" || taskList[i][0] == "Update") 
                    && taskList[i][2] == idPuerta)
                {
                    taskList.Remove(taskList[i]);
                }
            }
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
                            int idPuerta = Int32.Parse(task[2]);
                            Puerta toSave = puertas.Find((Puerta pt)=> pt.IdPuerta == idPuerta);
                            ServiceProvider.Instance.ServicePuertas.CreatePuerta(toSave);
                            break;
                        case "Update":
                            int idupdate = Int32.Parse(task[2]);
                            Puerta toUpdate = puertas.Find((Puerta pt) => pt.IdPuerta == idupdate); ;
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

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            List<int> puertas = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                puertas.Add((int)row.Cells["ColId"].Value);
            }

            this.puertasSeleccion = puertas;

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
