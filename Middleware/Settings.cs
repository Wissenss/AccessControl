using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Middleware
{
    /*
     * Esta Clase se encarga de la lectura y consulta de los settings guardados en el archivo .ini
     * Debería ser utilizada para acceder y guardar información escencial antes de conectar
     * a la base de datos
     */

    public class Settings : IniFile
    {
        static private readonly string path = "AccessControl.ini"; //el archivo .ini que lee deveria estar en ./Bin/AccessControl.ini

        public string Server
        {
            get { return this.Read("server", "Conexion"); }
            set { this.Write("server", value, "Conexion"); }
        }

        public string Port
        {
            get { return this.Read("port", "Conexion"); }
            set { this.Write("server", value, "Conexion");  }
        }
        public string Uid
        {
            get { return this.Read("uid", "Conexion"); }
            set { this.Write("uid", value, "Conexion"); }
        }
        public string Pwd
        {
            get { return this.Read("pwd", "Conexion"); }
            set { this.Write("pwd", value, "Conexion"); }
        }

        public string Database
        {
            get { return this.Read("database", "Conexion"); }
            set { this.Write("database", value, "Conexion"); }
        }

        public bool Actualizar //este parametro se utiliza para indicar si se quiere actualizar la estructura de la base de datos al iniciar la app
        {
            get 
            {
                string actualizar_string = this.Read("Actualizar", "Mantenimiento");
                bool actualizar = bool.Parse(actualizar_string);
                return actualizar;
            }
            set 
            {
                this.Write("Actualizar", value.ToString(), "Mantenimiento");
            }
        }

        public Settings() : base(path)
        {
        }

        /// <summary>
        /// Guarda los valores default. Esto sobreescribe el archivo!
        /// </summary>
        public void CleanFile()
        {
            //aca faltaria limpiar el archivo, pero IniFile no cuenta con un GetSections() (para regresar todas las sections y eliminarlas en un loop),
            //tons hace falta crearlo. La otra es eliminar el archivo all together, pero bueno dudo que se use anyway...

            //database settings
            this.Write("ServerPath", "", "Database");
            this.Write("Name", "", "Database");
            this.Write("Actualizar", "True", "Database");
        }
    }
}
