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



        //no se si lo de usuarios al final si se vaya a usar, si me hace mucho sentido tenerlo pero para
        //lo que pide el profe no parece que sea un requerimiento...
        //private int idUsuario { get; }
        //public string nombre { get; set; }
        //private string password { get; }
        //public int tipo_usuario { get; set; }
        //public long idCalendario { get; set; }

        //public Usuario(int idUsuario, string nombre, string password, int tipo, long idCalendario)
        //{
        //    this.idUsuario = idUsuario;
        //    this.nombre = nombre;
        //    this.password = password;
        //    this.tipo_usuario = tipo;
        //    this.idCalendario = idCalendario;
        //}

        // RE: Usuarios
        //Usuarios tal vez no sea necesario, como es un prototipo yo creo que con que cumpla con 
        //los requerimientos más cruciales deberá ser suficiente
        // (además es muy permisivo el profe con cosas que no quedan muy claras)
    }
}
