using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Middleware.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }

        public Persona() { }

        public Persona (int id, string nombres, string apellidos, string celular, string correo)
        {
            this.Id = id;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Celular = celular;
            this.Correo = correo;
        }
    }
}
