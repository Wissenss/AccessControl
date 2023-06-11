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
        /*
        Esta stack se crea cada vez qeu se abre la ventana
        para ejecutar las tareas cuando se clickea OK, 
        así, si se clickea Cancelar, entonces no se ejecuta
        ninguna tarea, así se puede mantener la DB segura
        hasta que se de click en "Aceptar"
        */
        private static List<string[]> taskStack;
        private static List<GrupoPuerta> gruposPuerta;

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
        }

        private void EjecutarAccion(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int idGr = Int32.Parse(row.Cells[0].Value.ToString());
            using (FDatosGrupoPuertas DDatosGrupoPuertas = new FDatosGrupoPuertas(idGr))
            {
                var res = DDatosGrupoPuertas.ShowDialog();
                //lógica para actualizar
            }
        }

        private void NuevoGrupo(object sender, EventArgs e)
        {
            using (FDatosGrupoPuertas DDatosGrupoPuertas = new FDatosGrupoPuertas())
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
                }
            }
        }

        private void EliminarGrupo(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string idGr = row.Cells[0].Value.ToString();
            taskStack.Add(new string[] { "Delete", $"{idGr}" });
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
                            //servicio borrarGrupo, requiere: idGrupo -> index
                            break;
                        case "Add":
                            GrupoPuerta toSave = gruposPuerta[index];
                            //Servicio guardar, requiere: Objeto <GrupoPuerta>
                            break;
                        case "Update":
                            //Servicio actualizar,  requiere: Objeto <Puerta>
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
            this.Dispose();
        }
    }
}
