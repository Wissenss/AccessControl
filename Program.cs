using Middleware;
using System;
using System.Windows.Forms;

namespace AccessControl
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //config de la app
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            //rutinas de inicio
            ServiceProvider svProvider = ServiceProvider.Instance;//crea el service provider

            if (new Settings().Actualizar) //actualiza/reinicia la estructura de la bd
            {
                DBUtils.InizializarDB(ServiceProvider.Instance);
                MessageBox.Show("Actualización Terminada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Application.Run(new Main());
        }
    }
}
