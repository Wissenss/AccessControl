using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
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
        public string Clave { get; set; }
        public string UID { get; set; }
        public MemoryStream Imagen { get; set; }

        public Persona() { }

        public Persona(MySqlDataReader reader)
        {
            this.Id = (int)reader[0];
            this.Nombres = (string)reader[1];
            this.Apellidos = (string)reader[2];
            this.Celular = (string)reader[3];
            this.Correo = (string)reader[4];
            this.Clave = (string)reader[5];
            this.UID = (string)reader[6];

            if (!reader.IsDBNull(7))
                this.Imagen = new MemoryStream((byte[])reader[7]);
        }

        public Persona (int id, string nombres, string apellidos, string celular, string correo)
        {
            this.Id = id;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Celular = celular;
            this.Correo = correo;
        }



        public override string ToString() //para que el list box muestre correctamente una lista de objetos
        {
            return this.Nombres;
        }
    }
}
