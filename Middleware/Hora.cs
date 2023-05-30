using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl.Models
{
    internal class Hora
    {
        private long IdHora { get; }
        private DateTime inicio { get; set; }
        private DateTime fin { get; set; }
        private long idSemana { get; set; }
        private string dia { get; set; }

        public Hora(long idHora, DateTime inicio, DateTime fin, long idSemana, string dia)
        {
            IdHora = idHora;
            this.inicio = inicio;
            this.fin = fin;
            this.idSemana = idSemana;
            this.dia = dia;
        }
    }
}
