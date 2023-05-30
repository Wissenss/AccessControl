using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl.Models
{
    internal class Usuario
    {
        private int idUsuario { get; }
        public string nombre { get; set; }
        private string password { get; }
        public int tipo_usuario { get; set; }
        public long idCalendario { get; set; }

        public Usuario(int idUsuario, string nombre, string password, int tipo, long idCalendario)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.password = password;
            this.tipo_usuario = tipo;
            this.idCalendario = idCalendario;
        }
    }
}
