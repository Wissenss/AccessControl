﻿using AccessControl.Catalogos;
using AccessControl.Generic;
using AccessControl.Models;
using Middleware;
using Middleware.Models;
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
    public partial class Main : Form
    {
        private int personaSeleccionada;
        private int puertaSeleccionada;

        public Main()
        {
            InitializeComponent();

            //esconde las tabs del control
            TCMonitor.Appearance = TabAppearance.FlatButtons;
            TCMonitor.ItemSize = new Size(0, 1);
            TCMonitor.SizeMode = TabSizeMode.Fixed;

            foreach (TabPage tab in TCMonitor.TabPages)
            {
                tab.Text = "";
            }
        }

        private void BtnSelectPersona_Click(object sender, EventArgs e)
        {
            using (FCatalogoPersonas DCatalogPersonas = new FCatalogoPersonas())
            {
                DCatalogPersonas.modo = ModoAcceso.Seleccion;
                if(DCatalogPersonas.ShowDialog() == DialogResult.OK)
                {
                    int personaSeleccionada = DCatalogPersonas.PersonasSeleccionadas[0];
                    Persona persona;
                    Error error = ServiceProvider.Instance.ServicePersonas.GetPersona(personaSeleccionada, out persona);
                    if(error != Error.NoError)
                    {
                        error.MostrarError();
                        return;
                    }

                    this.personaSeleccionada = persona.Id;
                    tbNombre.Text = persona.Nombres;
                    tbApellidos.Text = persona.Apellidos;
                    tbCorreo.Text = persona.Correo;
                    tbCelular.Text = persona.Celular;

                    if (persona.Imagen != null)
                    {
                        pbImagen.Image = Image.FromStream(persona.Imagen);
                    }
                }
            }
        }

        private void BtnSelectPuerta_Click(object sender, EventArgs e)
        {
            using (FCatalogoPuertas DCatalogPuertas = new FCatalogoPuertas())
            {
                DCatalogPuertas.modo = ModoAcceso.Seleccion;

                if(DCatalogPuertas.ShowDialog() == DialogResult.OK)
                {
                    int puertaSeleccionada = DCatalogPuertas.puertasSeleccion[0];

                    Puerta puerta;
                    Error error = ServiceProvider.Instance.ServicePuertas.GetPuerta(puertaSeleccionada, out puerta);
                    if (error != Error.NoError)
                    {
                        error.MostrarError();
                        return;
                    }

                    this.puertaSeleccionada = puerta.IdPuerta;
                    tbDescripcion.Text = puerta.Descripcion;
                    tbObservaciones.Text = puerta.Observaciones;
                }
            }
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            FAbout DAbout = new FAbout();

            DAbout.ShowDialog();

            DAbout = null;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            //resize a la barra de navegacion
            int newButtonHeight = this.Height / 5;
            int newButtonWidth = this.Width / 8;

            Size newButtonSize = new Size(newButtonWidth, newButtonHeight);

            BtnPersonas.MinimumSize = newButtonSize;//el flow-layout encoje los objetos, entonces esto lo evita

            BtnPersonas.Size = newButtonSize;
            BtnGPersonas.Size = newButtonSize;
            BtnPuertas.Size = newButtonSize;
            BtnGPuertas.Size = newButtonSize;
            BtnItinerario.Size = newButtonSize;
            BtnAbout.Size = newButtonSize;

            panel2.Size = new Size(this.Width, newButtonHeight + 6); //se le suma 6 por el padding

            //resize al panel de monitoreo/acciones
            int newPanelHeight = this.Height - (newButtonHeight + 6 + 3);
            int newPanelWidth = this.Width;

            //TCMonitor.Size = new Size(newPanelWidth, newPanelHeight);
            panel1.Size = new Size(newPanelWidth, newPanelHeight);
        }

        private void BtnPersonas_Click(object sender, EventArgs e)
        {
            using(FCatalogoPersonas DCatalogPersonas = new FCatalogoPersonas())
            {
                DCatalogPersonas.ShowDialog();
            }
        }

        private void BtnPuertas_Click(object sender, EventArgs e)
        {
            using(FCatalogoPuertas DCatalogoPuertas = new FCatalogoPuertas())
            {
                DCatalogoPuertas.ShowDialog();
            }
        }

        private void BtnGPuertas_Click(object sender, EventArgs e)
        {
            using(FCatalogoGruposPuertas DCatalogoGruposPuertas = new FCatalogoGruposPuertas())
            {
                DCatalogoGruposPuertas.ShowDialog();
            }
        }

        private void BtnItinerario_Click(object sender, EventArgs e)
        {
            using(FCatalogoSemanasTipo DCatalogoItinerario = new FCatalogoSemanasTipo())
            {
                DCatalogoItinerario.ShowDialog();
            }
        }

        private void BtnGPersonas_Click(object sender, EventArgs e)
        {
            using (FCatalogoGuposPersonas DCatalogoGruposPersonas = new FCatalogoGuposPersonas())
            {
                DCatalogoGruposPersonas.ShowDialog();
            }
        }

        private void BtnProbarAcceso_Click(object sender, EventArgs e)
        {
            if(this.personaSeleccionada == 0)
            {
                MessageBox.Show("Debe seleccionar una persona...");
                return;
            }

            if(this.puertaSeleccionada == 0)
            {
                MessageBox.Show("Debe seleccionar una puerta...");
                return;
            }

            DateTime Fecha = (DateTime)datePicker.Value;
            DateTime Hora = (DateTime)timePicker.Value;

            int persona = this.personaSeleccionada;
            int puerta = this.puertaSeleccionada;

            Error error = ServiceProvider.Instance.ServiceSemanasTipo.IntentarAcceso(persona, puerta, Fecha);
            if(error == Error.Desconocido)
            {
                error.MostrarError();
                return;
            }

            if(error == Error.LoginFallido)
            {
                MessageBox.Show("Acceso Denegado");
            }
            else
            {
                MessageBox.Show("Acceso Concedido");
            }
        }
    }
}
