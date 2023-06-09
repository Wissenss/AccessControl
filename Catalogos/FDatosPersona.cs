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
    public partial class FDatosPersona : Form
    {
        public FDatosPersona()
        {
            InitializeComponent();
        }
        
        public FDatosPersona(string[] personData)
        {
            InitializeComponent();
        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void cbRol_DrawItem(object sender, DrawItemEventArgs e) //para que el combobox tenga el hightlight morado
        {
            var combo = sender as ComboBox;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(90, 76, 151)), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlLightLight), e.Bounds);
            }

            e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                          e.Font,
                                          new SolidBrush(Color.Black),
                                          new Point(e.Bounds.X, e.Bounds.Y));
        }
    }
}
