using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco.Dominio
{
    public class TipoCuenta
    {
        public int IdTipo { get; set; }
        public string NombreTipo { get; set; }

        public TipoCuenta()
        {

        }

        public TipoCuenta(int idTipo, string nombreTipo)
        {
            IdTipo = idTipo;
            NombreTipo = nombreTipo;
        }
    }
}
