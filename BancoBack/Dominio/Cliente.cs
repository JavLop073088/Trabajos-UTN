using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBack.Dominio
{
    public class Cliente
    {
        public int NroCliente { get; set; }
        public string NomCliente { get; set; }
        public string ApeCliente { get; set; }
        public int dni { get; set; }
        public DateTime FechaBaja { get; set; }

        public List<Cuenta> Cartera { get; set; }

        public Cliente()
        {
            Cartera = new List<Cuenta>();
        }

        public void AgregarCuenta(Cuenta oCuenta)
        {
            Cartera.Add(oCuenta);
        }

        public void QuitarCuenta(int num)
        {
            Cartera.RemoveAt(num);
        }

        public double CalcularTotalCartera()
        {
            double total = 0;
            foreach (Cuenta cta in Cartera)
            {
                total += cta.Saldo;
            }
            return total;
        }

        public override string ToString()
        {
            string mensaje;
            return mensaje = "Nombre: " + NomCliente + "\n" +
                             "Apellido: " + ApeCliente + "\n" +
                             "DNI: " + dni;

        }
        public string GetFechaBajaFormato()
        {
            string aux = FechaBaja.ToString("dd/MM/yyyy");
            return aux.Equals("01/01/0001") ? "" : aux;
        }
    }
}
