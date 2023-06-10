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
    public partial class FDatosGrupoPuertas : Form
    {
        public FDatosGrupoPuertas()
        {
            InitializeComponent();
        }
        private void FDatosGrupoPuertas_Load(object sender, EventArgs e)
        {
            ServiceProvider.Instance.ServicePuertas.GetPuertas(out List<Puerta> puertas);
            //temporal para testing...
            //****************************************
            foreach (Puerta puerta in puertas)
            {
                lbPuertas.Items.Add(puerta.Descripcion);
            }
            //****************************************

            ActualizarControlesActivos();
        }

        private void BtnAddSelected_Click(object sender, EventArgs e)
        {
            while (lbPuertas.SelectedItems.Count > 0)
            {
                string item = (string)lbPuertas.SelectedItems[0];
                lbMiembros.Items.Add(item);
                lbPuertas.Items.Remove(item);
            }
            ActualizarControlesActivos();
        }

        private void BtnRemoveSelected_Click(object sender, EventArgs e)
        {
            while (lbMiembros.SelectedItems.Count > 0)
            {
                string item = (string)lbMiembros.SelectedItems[0];
                lbPuertas.Items.Add(item);
                lbMiembros.Items.Remove(item);
            }
            ActualizarControlesActivos();
        }

        private void BtnAddAll_Click(object sender, EventArgs e)
        {
            while (lbPuertas.Items.Count > 0)
            {
                string item = (string)lbPuertas.Items[0];
                lbMiembros.Items.Add(item);
                lbPuertas.Items.Remove(item);
            }
            ActualizarControlesActivos();
        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            while (lbMiembros.Items.Count > 0)
            {
                string item = (string)lbMiembros.Items[0];
                lbPuertas.Items.Add(item);
                lbMiembros.Items.Remove(item);
            }
            ActualizarControlesActivos();
        }

        private void ActualizarControlesActivos()
        {
            BtnAddSelected.Enabled = lbPuertas.SelectedItems.Count > 0;
            BtnRemoveSelected.Enabled = lbMiembros.SelectedItems.Count > 0;
            BtnAddAll.Enabled = lbPuertas.Items.Count > 0;
            BtnRemoveAll.Enabled = lbMiembros.Items.Count > 0;
        }

        private void DrawItemSelected(object sender, DrawItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;

            if (e.Index < 0) return;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.FromArgb(90, 76, 151));

            e.DrawBackground();
            e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void On_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarControlesActivos();
        }
    }
}
