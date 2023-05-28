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
    }
}
