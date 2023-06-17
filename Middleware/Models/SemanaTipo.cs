using Middleware.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl.Models
{
    public class SemanaTipo
    {
        static readonly string[] Days = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        public int IdSemanaTipo { get; set; }
        public string Descripcion { get; set; }

        //cada día se almacena en una lista
        public List<DiaTipo> semana = new List<DiaTipo>();

        public SemanaTipo(string Descripcion)
        {
            this.Descripcion = Descripcion;
            for (int i = 0; i < 7; i++)
            {
                semana.Add(new DiaTipo(Days[i]));
            }
        }

        public SemanaTipo(MySqlDataReader reader)
        {
            this.IdSemanaTipo = (int)reader[0];
            this.Descripcion = (string)reader[1];
        }

        public SemanaTipo(int idSemanaTipo, string Descripcion)
        {
            this.IdSemanaTipo = idSemanaTipo;
            this.Descripcion = Descripcion;
            for (int i = 0; i < 7; i++)
            {
                semana.Add(new DiaTipo(Days[i]));
            }
        }

        //recibimos los DiasTipo, para usar FindAll y setear directo el diccionario
        public void SetDerechos(List<DiaTipo> dias)
        {
            this.semana = dias;
        }
    }
}
