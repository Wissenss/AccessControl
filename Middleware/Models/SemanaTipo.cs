using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl.Models
{
    internal class SemanaTipo
    {
       string[] Days = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        //Cada día tiene un diccionario, donde la llave es la hora,
        //y el valor, un objeto o arreglo con los derechos de puertas y personas
        //correspondientes a la hora
        private class Dia
        {
            public String name;
            public Dictionary<int, Object> horariosAcceso;
            public Dia(string name)
            {
                this.name = name;
            }

            public Dia(string name, Dictionary<int, object> horariosAcceso) : this(name)
            {
                this.horariosAcceso = horariosAcceso;
            }
        }

        //cada día se almacena en una lista
        private List<Dia> semana = new List<Dia>();

        public SemanaTipo()
        {
            for(int i = 0; i<7; i++)
            {
                semana.Add(new Dia(Days[i]));
            }
        }
    }
}
