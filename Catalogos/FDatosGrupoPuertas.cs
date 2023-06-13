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
using Middleware.Models;

namespace AccessControl.Catalogos
{
    public partial class FDatosGrupoPuertas : Form
    {
        private int idGrupo = -1;
        private string Descripcion { get; set; }
        private string Nombre { get; set; }

        private GrupoPuerta grupoTemporal;

        List<GrupoPuerta> gruposRegistrados;

        List<Puerta> members;
        List<Puerta> puertasDisponibles;
        public FDatosGrupoPuertas(List<Puerta> sinAsignar)
        {
            InitializeComponent();
            this.members = new List<Puerta>();
            this.puertasDisponibles = sinAsignar;
        }
        public FDatosGrupoPuertas(int idGrupo, GrupoPuerta gruporecibido, List<Puerta> sinAsignar)
        {
            InitializeComponent();
            this.idGrupo = idGrupo;
            this.grupoTemporal = gruporecibido;
            this.tbNombre.Text = gruporecibido.Nombre;
            this.tbDescripcion.Text = gruporecibido.Descripcion;
            this.puertasDisponibles = sinAsignar;
        }

        private void FDatosGrupoPuertas_Load(object sender, EventArgs e)
        {

            ServiceProvider.Instance.ServicePuertas.GetGruposDePuertas(out gruposRegistrados);

            if (this.idGrupo != -1)
            {
                this.members = grupoTemporal.GetPuertasAsociadas();
            }

            foreach (Puerta miembro in members)
            {
                lbMiembros.Items.Add(miembro.Descripcion);
            }

            foreach (Puerta puerta in puertasDisponibles)
            {
                lbPuertas.Items.Add(puerta.Descripcion);
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
                        puertasDisponibles[i].idGrupo = this.idGrupo;
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
                for (int i = 0; i < members.Count; i++)
                {
                    if (members[i].Descripcion == item)
                    {
                        members[i].idGrupo = -1;
                        puertasDisponibles.Add(members[i]);
                        members.Remove(members[i]);
                        break;
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

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            while (lbMiembros.Items.Count > 0)
            {
                string item = (string)lbMiembros.Items[0];
                for (int i = 0; i < members.Count; i++)
                {
                    if (members[i].Descripcion == item)
                    {
                        puertasDisponibles.Add(members[i]);
                        members.Remove(members[i]);
                        break;
                    }
                }
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
            //Si el idGrupo se quedó en -1, estamos en modo creativo
            //si no es -1, entonces estamos editando
            if (this.idGrupo == -1) return new string[] { this.Nombre, this.Descripcion };
            return new string[] { this.Nombre, this.Descripcion, this.idGrupo.ToString() };
        }

        public List<Puerta> GetMemebers()
        {
            return this.members;
        }

        public List<Puerta> GetPuertasDisponibles()
        {
            return this.puertasDisponibles;
        }

        private bool checkDisponibilidad(Puerta puerta)
        {
            foreach (GrupoPuerta grupo in gruposRegistrados)
            {
                foreach (Puerta asociada in grupo.GetPuertasAsociadas())
                {
                    if (puerta.Descripcion == asociada.Descripcion) return false;
                }
            }
            return true;
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
