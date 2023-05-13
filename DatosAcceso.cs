using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControl
{
    public partial class DatosAcceso : Form
    {
        public string Nombre { get; set; }
        public string Clave { get; set; }

        private readonly SerialPort puertoSerial;

        private delegate void SetClave(string nuevaClave);

        public DatosAcceso(SerialPort puerto)
        {
            InitializeComponent();

            this.puertoSerial = puerto;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Nombre = TxbNombre.Text;
            Clave = TxbClave.Text;
        }

        public void On_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = puertoSerial.ReadLine();

            if (data.Trim().StartsWith("UID: "))
            {
                string uid = data.Substring(4).Replace("\r", "");
                this.BeginInvoke(new SetClave(On_SetClave), new object[] {uid});
            }
        }

        private void On_SetClave(string nuevaClave)
        {
            TxbClave.Text = nuevaClave;
        }
    }
}
