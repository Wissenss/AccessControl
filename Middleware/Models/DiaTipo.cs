using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Models
{
    public class DiaTipo
    {
        public String name;
        public Dictionary<int, Dictionary<GrupoPuerta, List<GrupoPersona>>> horariosAcceso { get; set; }

        public DiaTipo(string name)
        {
            this.name = name;
            generarHoras();
        }

        public DiaTipo(string name, Dictionary<int, Dictionary<GrupoPuerta, List<GrupoPersona>>> horariosAcceso) : this(name)
        {
            this.horariosAcceso = horariosAcceso;
        }

        private void generarHoras()
        {
            this.horariosAcceso = new Dictionary<int, Dictionary<GrupoPuerta, List<GrupoPersona>>>();
            for (int i = 8; i <= 14; i++)
            {
                this.horariosAcceso.Add(i, new Dictionary<GrupoPuerta, List<GrupoPersona>>());
            }
        }
    }
}
