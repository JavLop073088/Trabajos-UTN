using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBack.Dominio
{
    public class Usuario
    {
        public int Legajo { get; set; }
        public string NomUsuario { get; set; }
        public string ApeUsuario { get; set; }
        public string ClaveUsuario { get; set; }

        public Usuario(int legajo, string nomUsuario, string apeUsuario, string claveUsuario)
        {
            Legajo = legajo;
            NomUsuario = nomUsuario;
            ApeUsuario = apeUsuario;
            ClaveUsuario = claveUsuario;
        }

        public Usuario()
        {

        }
    }
}
