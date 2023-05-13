using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace AccessControl
{
    public partial class Monitor : Form
    {
        private readonly string puertoSerial_nombre = "COM6";
        private readonly int puertoSerial_frecuencia = 9600;
        private SerialPort puertoSerial;

        private bool alarmaActivada;
        private bool addingAccess;

        private delegate void SetTextDeleg(string stringData, bool isIncoming);
        private delegate void SetSistemStatus(string incomingStatus);

        public Monitor()
        {
            InitializeComponent();

            LblPuertoNombre.Text = puertoSerial_nombre;
            LblPuertoFrecuencia.Text = String.Format("{0} baud", puertoSerial_frecuencia);

            puertoSerial = new SerialPort();
            try
            {
                puertoSerial.PortName = puertoSerial_nombre;
                puertoSerial.BaudRate = puertoSerial_frecuencia;
                puertoSerial.DataReceived += new SerialDataReceivedEventHandler(On_DataReceived);
                puertoSerial.Open();
                RtbSerialMonitor.Text = String.Format("Connexion exitosa a {0}, {1} baud!\n", puertoSerial_nombre, puertoSerial_frecuencia);
            }
            catch (Exception e)
            {
                RtbSerialMonitor.Text = String.Format("Imposible conectar a {0}, {1} baud!\n", puertoSerial_nombre, puertoSerial_frecuencia);
                RtbSerialMonitor.Text = RtbSerialMonitor.Text + String.Format("\n\tCausa: {0}", e.Message);
            }

            alarmaActivada = false;
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            puertoSerial.Write("Open");
            WriteToSerialMonitor("Open", false);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            puertoSerial.Write("Close");
            WriteToSerialMonitor("Close", false);
        }

        private void BtnAlarma_Click(object sender, EventArgs e)
        {
            if(! alarmaActivada)
            {
                puertoSerial.Write("SoundAlarm");
                WriteToSerialMonitor("SoundAlarm", false);
                alarmaActivada = true;
                BtnAlarma.Text = "Detener Alarma";
            }
            else
            {
                puertoSerial.Write("StopAlarm");
                WriteToSerialMonitor("StopAlarm", false);
                alarmaActivada = false;
                BtnAlarma.Text = "Probar Alarma";
            }
        }

        private void BtnAddAcceso_Click(object sender, EventArgs e)
        {
            addingAccess = true; 
            using (DatosAcceso datosAcceso = new DatosAcceso(puertoSerial))
            {
                SerialDataReceivedEventHandler eventHandler = new SerialDataReceivedEventHandler(datosAcceso.On_DataReceived);
                puertoSerial.DataReceived += eventHandler;

                if (datosAcceso.ShowDialog() == DialogResult.OK)
                {
                    TbUsuarios.BeginLoadData();
                    DataRow nuevoUsuario = TbUsuarios.NewRow();
                    nuevoUsuario["Nombre"] = datosAcceso.Nombre;
                    nuevoUsuario["Clave"] = datosAcceso.Clave;
                    TbUsuarios.Rows.Add(nuevoUsuario);
                    TbUsuarios.EndLoadData();
                }

                puertoSerial.DataReceived -= eventHandler;
            }
            addingAccess = false;
        }

        private void BtnConsultarAccesos_Click(object sender, EventArgs e)
        {

        }

        private void On_DataReceived(object sender, SerialDataReceivedEventArgs e) // Multi-thread!
        {
            string data = puertoSerial.ReadLine();

            this.BeginInvoke(new SetTextDeleg(WriteToSerialMonitor), new object[] { data, true });

            if (data.Trim().StartsWith("UID: ") && !addingAccess)
            {
                string uid = data.Substring(4).Replace("\r", "");

                DataRow[] registros = TbUsuarios.Select("Clave='" + uid + "'");
                if(registros.Length > 0)
                {
                    puertoSerial.Write("Open");
                }
                else
                {
                    puertoSerial.Write("Close");
                }
            }

            this.BeginInvoke(new SetSistemStatus(UpdateSistemStatus), new object[] { data });
        }

        private void WriteToSerialMonitor(string stringData, bool isIncoming)
        {
            string dataOrigin = isIncoming ? "Incoming" : "Outgoing";

            RtbSerialMonitor.Text = RtbSerialMonitor.Text + String.Format("{0}: {1}\n", dataOrigin, stringData);
        }

        private void UpdateSistemStatus(string incomingStatus)
        {
            incomingStatus = incomingStatus.Trim();
            if(incomingStatus.StartsWith("UID: "))
            {
                //not implemented yet!
            }
            else if (incomingStatus.Equals("Open called"))
            {
                PbSistemStatus.Image = AccessControl.Properties.Resources.Door_Open;
                LblSistemStatus.Text = "Abierto";
            }
            else if (incomingStatus.Equals("Close called"))
            {
                PbSistemStatus.Image = AccessControl.Properties.Resources.Door_Close;
                LblSistemStatus.Text = "Cerrado";
            }
            else if (incomingStatus.Equals("SoundAlarm called"))
            {
                PbSistemStatus.Image = AccessControl.Properties.Resources.Alarm_Bell;
                LblSistemStatus.Text = "Alarma Activada";
            }
            else if (incomingStatus.Equals("Stop called"))
            {
                PbSistemStatus.Image = AccessControl.Properties.Resources.Door_Close;
                LblSistemStatus.Text = "Cerrado";
            }
            else
            {
                PbSistemStatus.Image = null;
                LblSistemStatus.Text = "Desconocido";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(puertoSerial.IsOpen)
            {
                puertoSerial.Close();
            }
        }
    }
}
