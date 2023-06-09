using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Models
{
    public class DetallesDeAcceso
    {
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }

        //Por cada grupo de puertas, nos dice qué Grupos de personas pueden acceder
        Dictionary<GrupoPuerta, List<GrupoPersona>> AccesoPorPuerta { get; set; }

        public DetallesDeAcceso(int HoraInicio, int HoraFin) {
            this.HoraInicio = HoraInicio;
            this.HoraFin = HoraFin;
            //servicio para traer los datos desde la DB
            this.AccesoPorPuerta = new Dictionary<GrupoPuerta, List<GrupoPersona>>();
        }
    }
}
