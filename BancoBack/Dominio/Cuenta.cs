using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco.Dominio
{
    public class Cuenta
    {
        public string Cbu { get; set; }
        public double Saldo { get; set; }
        public DateTime UltimoMov { get; set; }
        public TipoCuenta TipoCta { get; set; }

        public Cuenta()
        {

        }

        public Cuenta(string cbu, double saldo, DateTime ultimoMov, TipoCuenta tipoCta)
        {
            Cbu = cbu;
            Saldo = saldo;
            UltimoMov = ultimoMov;
            TipoCta = tipoCta;
        }
    }
}
