using Middleware;
using Middleware.Models;
using AccessControl.Models;
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
    public partial class FDatosSemanaTipoAccesos : Form
    {
        Dictionary<GrupoPuerta, List<GrupoPersona>> derechosHora;
        List<GrupoPersona> personas;
        List<GrupoPuerta> puertas;
        GrupoPuerta puertaKey;
        public FDatosSemanaTipoAccesos(Dictionary<GrupoPuerta, List<GrupoPersona>> derechosHora)
        {
            InitializeComponent();
            this.derechosHora = derechosHora;
            ServiceProvider.Instance.ServicePersonas.GetGruposDePersonas(out personas);
            ServiceProvider.Instance.ServicePuertas.GetGruposDePuertas(out puertas);
            FillData();
        }

        private void FillData()
        {
            foreach (KeyValuePair<GrupoPuerta, List<GrupoPersona>> porPuerta in derechosHora)
            {
                chbPuertas.Items.Add(porPuerta.Key.Nombre, true);
            }
            foreach (GrupoPuerta gp in puertas)
            {
                if (!derechosHora.Keys.Any(key => key.Nombre == gp.Nombre))
                {
                    chbPuertas.Items.Add(gp.Nombre, false);

                }
            }
        }

        private void ShowPersonas(object sender, EventArgs e)
        {
            string nombrePuertas = chbPuertas.Text;

            try
            {
                this.puertaKey = derechosHora.Keys.Where(key => key.Nombre == nombrePuertas).First();
            }
            catch (Exception)
            {
                chbPersonas.Items.Clear();
                return;
            }
            if (this.puertaKey is null) return;
            List<GrupoPersona> asociadas = derechosHora[this.puertaKey];

            for (int i = 0; i < asociadas.Count; i++)
            {
                chbPersonas.Items.Add(asociadas[i].Nombre, true);
            }

            foreach (GrupoPersona gp in personas)
            {
                if (!asociadas.Any((persona) => persona.idGrupoPersona == gp.idGrupoPersona))
                {
                    chbPersonas.Items.Add(gp.Nombre, false);

                }
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPersona(object sender, ItemCheckEventArgs e)
        {
            string nombreSeleccionado = chbPersonas.Items[e.Index].ToString();
            if (!chbPersonas.GetItemChecked(e.Index))
            {
                GrupoPersona añadir = personas.Find((persona) => persona.Nombre == nombreSeleccionado);
                if (!derechosHora[puertaKey].Any(persona => persona.idGrupoPersona == añadir.idGrupoPersona))
                {
                    derechosHora[puertaKey].Add(añadir);
                }
            }
            else
            {
                GrupoPersona quitar = personas.Find((persona) => persona.Nombre == nombreSeleccionado);
                derechosHora[puertaKey].Remove(quitar);
            }
        }

        private void Add(object sender, ItemCheckEventArgs e)
        {
            string nombreGrupoSelecc = chbPuertas.Items[e.Index].ToString();
            if(!chbPuertas.GetItemChecked((e.Index)))
            {

            }
            else
            {

            }
        }
    }
}
