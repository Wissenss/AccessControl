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
    public partial class FDatosSemanaTipo : Form
    {
        public FDatosSemanaTipo()
        {
            InitializeComponent();
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
            for (int i = 6; i <= 22; i++)
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
                dtAccesos.Rows.Add(hora);
            }
            dtAccesos.EndLoadData();
        }

        private void addAccess_Click(object sender, EventArgs e)
        {
            using (FDatosSemanaTipoAccesos DDatosItinerarioAccesos = new FDatosSemanaTipoAccesos())
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
                using (FDatosSemanaTipoAccesos DDatosItinerarioAccesos = new FDatosSemanaTipoAccesos())
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
