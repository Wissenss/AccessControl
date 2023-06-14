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
    public partial class FDatosItinerario : Form
    {
        public FDatosItinerario()
        {
            InitializeComponent();
        }


        private void HorarioSemanasTipo_CellContentClick(object sender, EventArgs e)
        {

        }


        private void FDatosItinerario_Load_1(object sender, EventArgs e)
        {
            for (int i = 6; i <= 22; i++)
            {
                string horario;
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

                HorarioSemanasTipo.Rows.Add(horario);
            }

        }

        private void addAccess_Click(object sender, EventArgs e)
        {
            using (FDatosItinerarioAccesos DDatosItinerarioAccesos = new FDatosItinerarioAccesos())
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
                using (FDatosItinerarioAccesos DDatosItinerarioAccesos = new FDatosItinerarioAccesos())
                {
                    DDatosItinerarioAccesos.ShowDialog();
                }
            }
        }
    }
}
