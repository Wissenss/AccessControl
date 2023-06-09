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

        public Puerta(int idPuerta, string Descripcion, string Ubicacion, string observaciones)
        {
            this.IdPuerta = idPuerta;
            this.Ubicacion = Ubicacion;
            this.Descripcion = Descripcion;
            this.Observaciones = observaciones;
        }
    }
}
