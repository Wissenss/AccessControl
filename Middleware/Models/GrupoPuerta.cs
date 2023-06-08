using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessControl.Models;

namespace Middleware.Models
{
    public class GrupoPuerta
    {
        public int IdGrupoPuerta { get; set; }
        public string Nombre { get; set; }
        private List<Puerta> puertas;


        public GrupoPuerta(int idGrupoPuerta, string nombre)
        {
            IdGrupoPuerta = idGrupoPuerta;
            Nombre = nombre;
            this.puertas = new List<Puerta>();
        }

        public int AñadirPuerta(Puerta nuevaPuerta)
        {
            //aquí puede haber redundancia, pero vale la pena usar el 
            //servicio para traer la lista de todos los grupos, 
            //para comprobar que no hay una puerta en más de un grupo
            if (puertas.Contains(nuevaPuerta))
            {
                //Retorna 1 cuando la puerta ya está en el grupo
                return 1;
            }

            puertas.Add(nuevaPuerta);
            //si todo sale bien retorna 0
            return 0;
        }

        public int ModificarPuerta(Puerta nuevaPuerta)
        {
            int index = puertas.FindIndex((puerta) => puerta.IdPuerta == nuevaPuerta.IdPuerta);
            //si no existe en l alista, retorna 1
            if (index == -1) { return 1; }

            puertas[index] = nuevaPuerta;
            //si todo sale bien retorna 0
            return 0;
        }

        public int EliminarPuerta(Puerta puerta)
        {
            //si no existe en la lista, retorna 1
            if(!puertas.Contains(puerta)) { return 1; }
            
            puertas.Remove(puerta);
            return 0;
        }
    }
}
