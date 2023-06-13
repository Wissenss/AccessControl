using AccessControl.Models;
using Middleware;
using Middleware.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AccessControl.Generic;

namespace AccessControl.Catalogos
{
    public partial class FCatalogoGruposPuertas : Form
    {
        /*
        Cada vez que se crea una instancia, se genera una lista de tareas, al cerrar, 
        Si el usuario da en aceptar, se ejecutan las tareas, si da cancelar, no se ejecutan
        y no habrá cambios en DB
        */
        private bool changes = false;
        private static List<string[]> taskStack;
        private List<GrupoPuerta> gruposPuerta;
        private List<Puerta> puertasSinAsignar;
        public FCatalogoGruposPuertas()
        {
            InitializeComponent();
            taskStack = new List<string[]>();
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
            ServiceProvider.Instance.ServicePuertas.GetPuertasSinAsignar(out puertasSinAsignar);
        }

        //Editar
        private void EjecutarAccion(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int idGr = Int32.Parse(row.Cells[0].Value.ToString());
            using (FDatosGrupoPuertas DDatosGrupoPuertas = new FDatosGrupoPuertas(idGr, this.gruposPuerta[row.Index], this.puertasSinAsignar))
            {
                var res = DDatosGrupoPuertas.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string[] newGroup = DDatosGrupoPuertas.GetNewGroupData();
                    string Nombre = newGroup[0];
                    string Descripcion = newGroup[1];
                    int idGrupo = Int32.Parse(newGroup[2]); //recibimos el id en  un indice extra
                    List<Puerta> ptAsociadas = DDatosGrupoPuertas.GetMemebers();

                    gruposPuerta[row.Index] = new GrupoPuerta(idGrupo, Nombre, Descripcion, ptAsociadas);
                    taskStack.Add(new string[] { "Update", $"{row.Index}" });
                    //Modificar las columnas desde el designer
                    row.SetValues(idGrupo, Nombre, Descripcion);
                    puertasSinAsignar = DDatosGrupoPuertas.GetPuertasDisponibles();
                    this.changes = true;
                }
            }
        }

        //Crear
        private void NuevoGrupo(object sender, EventArgs e)
        {
            using (FDatosGrupoPuertas DDatosGrupoPuertas = new FDatosGrupoPuertas(this.puertasSinAsignar))
            {
                var res = DDatosGrupoPuertas.ShowDialog();
                if (res == DialogResult.OK)
                {
                    int idGrupo = GetNextId();
                    string[] newGroup = DDatosGrupoPuertas.GetNewGroupData();
                    string Nombre = newGroup[0];
                    string Descripcion = newGroup[1];
                    List<Puerta> ptAsociadas = DDatosGrupoPuertas.GetMemebers();
                    gruposPuerta.Add(new GrupoPuerta(idGrupo, Nombre, Descripcion, ptAsociadas));

                    taskStack.Add(new string[] { "Add", $"{gruposPuerta.Count() - 1}" });

                    DataRow row = dtGruposPuertas.NewRow();
                    //Modificar las columnas desde el designer
                    row["idGrupo"] = idGrupo;
                    row["Nombre"] = Nombre;
                    row["Descripcion"] = Descripcion;
                    dtGruposPuertas.Rows.Add(row);
                    puertasSinAsignar = DDatosGrupoPuertas.GetPuertasDisponibles();
                    this.changes = true;
                }
            }
        }

        //Eliminar
        private void EliminarGrupo(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string idGr = row.Cells[0].Value.ToString();
            gruposPuerta.Remove(gruposPuerta[row.Index]);
            dataGridView1.Rows.RemoveAt(row.Index);
            taskStack.Add(new string[] { "Delete", $"{idGr}" });
            this.changes = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Lógica para ejecutar la lista de tareas
            if (taskStack.Count > 0)
            {
                foreach (string[] task in taskStack)
                {
                    int index = Int32.Parse(task[1]);
                    switch (task[0])
                    {
                        case "Delete":
                            ServiceProvider.Instance.ServicePuertas.DeleteGrupoPuerta(index, out bool status);
                            break;
                        case "Add":
                            GrupoPuerta toSave = gruposPuerta[index];
                            ServiceProvider.Instance.ServicePuertas.SaveGrupoPuertas(toSave, out status);
                            break;
                        case "Update":
                            GrupoPuerta toUpdate = gruposPuerta[index];
                            ServiceProvider.Instance.ServicePuertas.UpdateGrupoPuertas(toUpdate, out status);
                            if (puertasSinAsignar.Count > 0)
                            {
                                ServiceProvider.Instance.ServicePuertas.UpdatePuertasDisponibles(this.puertasSinAsignar, out status);
                            }
                            break;
                    }
                }
            }
            this.Dispose();
        }

        private int GetNextId()
        {
            int max = Int32.MinValue;
            foreach (GrupoPuerta gp in gruposPuerta)
            {
                max = (gp.IdGrupoPuerta > max) ? gp.IdGrupoPuerta : max;
            }
            return max + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!changes)
            {
                this.Dispose();
                return;
            }
            using (MensajeConfirmacion confirmacion = new MensajeConfirmacion())
            {
                var res = confirmacion.ShowDialog();
                if (res == DialogResult.OK)
                {
                    this.Dispose();
                }
                else { return; }
            }
        }
    }
}
