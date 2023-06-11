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
        private int idGrupo = -1;
        private string Descripcion { get; set; }
        private string Nombre { get; set; }

        List<Puerta> members;
        List<Puerta> puertasDisponibles;
        public FDatosGrupoPuertas()
        {
            InitializeComponent();
            this.members = new List<Puerta>();
        }
        public FDatosGrupoPuertas(int idGrupo)
        {
            InitializeComponent();
            this.idGrupo = idGrupo;
        }
        private void FDatosGrupoPuertas_Load(object sender, EventArgs e)
        {
            ServiceProvider.Instance.ServicePuertas.GetPuertas(out puertasDisponibles);
            // puertasDisponibles = new List<Puerta>(puertas);
            if (idGrupo != -1)
            {
                ServiceProvider.Instance.ServicePuertas.GetPuertasByGroup(this.idGrupo, out members, false);
            }
            foreach (Puerta miembro in members)
            {
                lbMiembros.Items.Add(miembro.Descripcion);
            }

            foreach (Puerta puerta in puertasDisponibles)
            {
                bool flag = false;
                foreach (Puerta miembro in members)
                {
                    if (miembro.IdPuerta == puerta.IdPuerta)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag) lbPuertas.Items.Add(puerta.Descripcion);
            }

            ActualizarControlesActivos();
        }

        private void BtnAddSelected_Click(object sender, EventArgs e)
        {
            while (lbPuertas.SelectedItems.Count > 0)
            {
                string item = (string)lbPuertas.SelectedItems[0];
                for (int i = 0; i < puertasDisponibles.Count; i++)
                {
                    if (puertasDisponibles[i].Descripcion == item)
                    {
                        members.Add(puertasDisponibles[i]);
                        puertasDisponibles.Remove(puertasDisponibles[i]);
                        break;
                    }
                }
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
                foreach (Puerta pt in members)
                {
                    if (pt.Descripcion == item)
                    {
                        puertasDisponibles.Add(pt);
                        members.Remove(pt);
                    }
                }
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

        public string[] GetNewGroupData()
        {
            return new string[] { this.Nombre, this.Descripcion };
        }

        public List<Puerta> GetMemebers()
        {
            return this.members;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Descripcion = tbDescripcion.Text;
            this.Nombre = tbNombre.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
