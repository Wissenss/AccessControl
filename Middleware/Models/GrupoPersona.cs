using AccessControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Models
{
    public class GrupoPersona
    {
        public int idGrupoPersona { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Persona> personas;

        public GrupoPersona() 
        {
            this.personas = new List<Persona>();
        }

        public GrupoPersona(int idGrupoPersona, string nombre)
        {
            //podríamos usar un servicio para traer las personas directo de la base de datos
            //si la respuesta está vacía, lo igualamos a una nueva lsita
            this.idGrupoPersona = idGrupoPersona;
            Nombre = nombre;
            this.personas = new List<Persona>();
        }
        public GrupoPersona(int idGrupoPersona, string nombre, List<Persona> personasAsociadas)
        {
            //podríamos usar un servicio para traer las personas directo de la base de datos
            //si la respuesta está vacía, lo igualamos a una nueva lsita
            this.idGrupoPersona = idGrupoPersona;
            Nombre = nombre;
            this.personas = personasAsociadas;
        }

        public int AñadirPersona(Persona nuevaPersona)
        {
            if (personas.Contains(nuevaPersona))
            {
                //Retorna 1 cuando la puerta ya está en el grupo
                return 1;
            }

            personas.Add(nuevaPersona);
            //si todo sale bien retorna 0
            return 0;
        }

        public int ModificarPersona(Persona nuevaPersona)
        {
            int index = personas.FindIndex((persona) => persona.Id == nuevaPersona.Id);
            //si no existe en l alista, retorna 1
            if (index == -1) { return 1; }

            personas[index] = nuevaPersona;
            //si todo sale bien retorna 0
            return 0;
        }

        public int EliminarPersona(Persona persona)
        {
            //si no existe en la lista, retorna 1
            if (!personas.Contains(persona)) { return 1; }

            personas.Remove(persona);
            return 0;
        }
    }
}
