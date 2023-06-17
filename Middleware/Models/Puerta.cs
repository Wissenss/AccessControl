using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl.Models
{
    public class Puerta
    {
        public int IdPuerta { get; set; }
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; }
        public string Observaciones { get; set; }

        public int idGrupo { get; set; }

        public Puerta(int idPuerta, string Descripcion, string Ubicacion, string observaciones, int idGrupo)
        {
            this.IdPuerta = idPuerta;
            this.Ubicacion = Ubicacion;
            this.Descripcion = Descripcion;
            this.Observaciones = observaciones;
            this.idGrupo = idGrupo;
        }

        public Puerta(MySqlDataReader reader)
        {
            this.IdPuerta = (int)reader[0];
            this.Descripcion = (string)reader[1];
            this.Ubicacion = (string)reader[2];
            this.Observaciones = (string)reader[3];
            this.idGrupo = (int)reader[4];
        }
    }
}
