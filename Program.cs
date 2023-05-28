using Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            //carga los ensamblados necesarios

            //config de la app
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //rutinas de inicio
            ServiceProvider svProvider = ServiceProvider.Instance;//crea el service provider

            if (new Settings().Actualizar)
            {
                DBUtils.InizializarDB(ServiceProvider.Instance);//actualiza/reinicia la estructura de la bd
            }

            Application.Run(new Main());
        }
    }
}
