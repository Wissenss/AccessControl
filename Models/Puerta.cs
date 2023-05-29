using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl.Models
{
    internal class Puerta
    {
        public int IdPuerta { get; set; }
        public int IdZona { get; set; }

        public Puerta(int idPuerta, int idZona) {
            this.IdPuerta = idPuerta;
            this.IdZona = idZona;
        }
    }
}
