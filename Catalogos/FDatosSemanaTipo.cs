using AccessControl.Models;
using Middleware.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControl.Catalogos
{
    public partial class FDatosSemanaTipo : Form
    {
        SemanaTipo semanaTemporal;
        bool isNew = false;
        public FDatosSemanaTipo()
        {
            InitializeComponent();
            isNew = true;
        }

        public FDatosSemanaTipo(SemanaTipo semana)
        {
            InitializeComponent();
            this.semanaTemporal = semana;
        }

        private void HorarioSemanasTipo_CellContentClick(object sender, EventArgs e)
        {

        }


        private void FDatosItinerario_Load_1(object sender, EventArgs e)
        {
            DataRow hora;
            string horario;

            dtAccesos.Clear();
            dtAccesos.BeginLoadData();
            for (int i = 8; i <= 14; i++)
            {
                if (i <= 11)
                {
                    if (i == 0)
                        horario = "12 am";
                    else
                        horario = i.ToString("D2") + " am";
                }
                else
                {
                    if (i == 12)
                        horario = "12 pm";
                    else
                        horario = (i - 12).ToString("D2") + " pm";
                }

                hora = dtAccesos.NewRow();
                hora["hora"] = horario;
                if (!isNew)
                {
                    //llenar los cuadros 
                    foreach (DiaTipo dia in semanaTemporal.semana)
                    {
                        hora[dia.name] = (dia.horariosAcceso[i].Values.Any((list) => list.Count > 0)) ? "Ver Datos" : "";
                    }
                }
                dtAccesos.Rows.Add(hora);
            }
            dtAccesos.EndLoadData();
        }

        private void addAccess_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 1) return;

            if (dataGridView1.SelectedCells[0].ColumnIndex == 0) return;
            string selectedDay = dataGridView1.Columns[dataGridView1.SelectedCells[0].ColumnIndex].HeaderText;
            int selectedHour = Int32.Parse(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString().Substring(0, 2));
            Dictionary<GrupoPuerta, List<GrupoPersona>> derechosHora;
            derechosHora = semanaTemporal.semana.Find((dia) => dia.name == selectedDay).horariosAcceso[selectedHour];
            using (FDatosSemanaTipoAccesos DDatosItinerarioAccesos = new FDatosSemanaTipoAccesos(derechosHora))
            {
                DDatosItinerarioAccesos.ShowDialog();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editAccess_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedCells.Count > 1) return;

                if (dataGridView1.SelectedCells[0].ColumnIndex == 0 ) return;
                string selectedDay = dataGridView1.Columns[dataGridView1.SelectedCells[0].ColumnIndex].HeaderText;
                int selectedHour = Int32.Parse(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString().Substring(0, 2));
                Dictionary<GrupoPuerta, List<GrupoPersona>> derechosHora;
                derechosHora = semanaTemporal.semana.Find((dia) => dia.name == selectedDay).horariosAcceso[selectedHour];
                using (FDatosSemanaTipoAccesos DDatosItinerarioAccesos = new FDatosSemanaTipoAccesos(derechosHora))
                {
                    DDatosItinerarioAccesos.ShowDialog();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
