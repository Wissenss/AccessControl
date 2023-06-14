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

        //Para facilitarnos esto, podemos usar dia/mes/año como ID
        public int IdSemanaTipo { get; set; }
        public string Descripcion { get; set; }

        public DateTime fechaInicio { get; set; }

        //cada día se almacena en una lista
        public List<DiaTipo> semana = new List<DiaTipo>();

        public SemanaTipo(MySqlDataReader reader)
        {
            this.IdSemanaTipo = (int)reader[0];
            this.Descripcion = (string)reader[1];
        }

        public SemanaTipo(int idSemanaTipo, string Descripcion, DateTime fechaInicio)
        {
            this.IdSemanaTipo = idSemanaTipo;
            this.Descripcion = Descripcion;
            this.fechaInicio = fechaInicio;
            for (int i = 0; i < 7; i++)
            {
                semana.Add(new DiaTipo(Days[i]));
            }
        }

        //recibimos los DiasTipo, para usar FindAll y setear directo el diccionario
        public void SetDerechos(List<DiaTipo> dias)
        {
            //recibimos los dias tipo listos.
            for (int i = 0; i < dias.Count; i++)
            {
                this.semana.FindIndex((DiaTipo dia) => dia.name == dias[i].name);
                this.semana[i].horariosAcceso = dias[i].horariosAcceso;
            }
        }
    }
}
