using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControl
{
    public partial class FDatosGrupoPersonas : Form
    {
        public FDatosGrupoPersonas()
        {
            InitializeComponent();
        }
        private void FDatosGrupoPersonas_Load(object sender, EventArgs e)
        {
            //temporal para testing...
            //****************************************
            lbPersonas.Items.Add("Persona Azul");
            lbPersonas.Items.Add("Persona Rojo");
            lbPersonas.Items.Add("Persona Morada");
            lbPersonas.Items.Add("Persona Amarilla");
            //****************************************

            ActualizarControlesActivos();
        }

        private void BtnAddSelected_Click(object sender, EventArgs e)
        {
            while(lbPersonas.SelectedItems.Count > 0)
            {
                string item = (string)lbPersonas.SelectedItems[0];
                lbMiembros.Items.Add(item);
                lbPersonas.Items.Remove(item);
            }
            ActualizarControlesActivos();
        }

        private void BtnRemoveSelected_Click(object sender, EventArgs e)
        {
            while (lbMiembros.SelectedItems.Count > 0)
            {
                string item = (string)lbMiembros.SelectedItems[0];
                lbPersonas.Items.Add(item);
                lbMiembros.Items.Remove(item);
            }
            ActualizarControlesActivos();
        }

        private void BtnAddAll_Click(object sender, EventArgs e)
        {
            while (lbPersonas.Items.Count > 0)
            {
                string item = (string)lbPersonas.Items[0];
                lbMiembros.Items.Add(item);
                lbPersonas.Items.Remove(item);
            }
            ActualizarControlesActivos();
        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            while (lbMiembros.Items.Count > 0)
            {
                string item = (string)lbMiembros.Items[0];
                lbPersonas.Items.Add(item);
                lbMiembros.Items.Remove(item);
            }
            ActualizarControlesActivos();
        }

        private void ActualizarControlesActivos()
        {
            BtnAddSelected.Enabled = lbPersonas.SelectedItems.Count > 0; 
            BtnRemoveSelected.Enabled = lbMiembros.SelectedItems.Count > 0;
            BtnAddAll.Enabled = lbPersonas.Items.Count > 0;
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
