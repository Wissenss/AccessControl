using AccessControl.Models;
using Middleware;
using Middleware.Models;
using MySqlX.XDevAPI.Relational;
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
        private List<string[]> taskList = new List<string[]>();
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
            SemanaTipo nuevaSemana;
            using (FDatosSemanaTipo DDatosItinerario = new FDatosSemanaTipo())
            {
                var res = DDatosItinerario.ShowDialog();
                if (res == DialogResult.OK)
                {
                    nuevaSemana = DDatosItinerario.GetSemana();
                    nuevaSemana.IdSemanaTipo = GetNextId();
                    DataRow row = dtSemanasTipo.NewRow();
                    row["Id"] = nuevaSemana.IdSemanaTipo;
                    row["Nombre"] = nuevaSemana.Descripcion;
                    this.listSemanasTipos.Add(nuevaSemana);
                    dtSemanasTipo.Rows.Add(row);
                    taskList.Add(new string[] { "Add", $"{nuevaSemana.IdSemanaTipo}" });
                    changes = true;
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;

            using (FDatosSemanaTipo DDatosItinerario = new FDatosSemanaTipo(listSemanasTipos[index]))
            {
                var res = DDatosItinerario.ShowDialog();
                if (res == DialogResult.OK)
                {
                    listSemanasTipos[index] = DDatosItinerario.GetSemana();
                    taskList.Add(new string[] { "Update", $"{listSemanasTipos[index].IdSemanaTipo}" });
                    changes = true;
                }
            }
        }


        private void delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int idSemana = listSemanasTipos[index].IdSemanaTipo;
            listSemanasTipos.Remove(listSemanasTipos[index]);
            taskList.Add(new string[] { "Delete", $"{idSemana}" });
            dataGridView1.Rows.RemoveAt(index);
            for (int i = 0; i < taskList.Count; i++)
            {
                if ((taskList[i][0] == "Add" || taskList[i][0] == "Update")
                    && taskList[i][1] == idSemana.ToString())
                {
                    taskList.Remove(taskList[i]);
                }
            }
            this.changes = true;
        }

        private int GetNextId()
        {
            int max = Int32.MinValue;
            foreach (SemanaTipo semana in listSemanasTipos)
            {
                max = (semana.IdSemanaTipo > max) ? semana.IdSemanaTipo : max;
            }
            return max + 1;
        }

        private void ExcecuteTasks(object sender, EventArgs e)
        {
            //Lógica para ejecutar la lista de tareas
            if (taskList.Count > 0)
            {
                foreach (string[] task in taskList)
                {
                    switch (task[0])
                    {
                        case "Delete":
                            int idEliminar = Int32.Parse(task[1]);
                            ServiceProvider.Instance.ServiceSemanasTipo.EliminarSemana(idEliminar);
                            break;
                        case "Add":
                            int idSalvar = Int32.Parse(task[1]);
                            SemanaTipo toSave = listSemanasTipos.Find((semana)=> semana.IdSemanaTipo == idSalvar);
                            ServiceProvider.Instance.ServiceSemanasTipo.SetSemanaTipo(toSave, true);
                            break;
                        case "Update":
                            int idupdate = Int32.Parse(task[1]);
                            SemanaTipo toupdate = listSemanasTipos.Find((semana) => semana.IdSemanaTipo == idupdate);
                            ServiceProvider.Instance.ServiceSemanasTipo.SetSemanaTipo(toupdate, false);
                            break;
                    }
                }
            }
            this.Dispose();
        }
    }
}
