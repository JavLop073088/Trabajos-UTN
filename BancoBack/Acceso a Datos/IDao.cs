using BancoBack.Dominio;
using BancoBack.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco.Acceso_a_Datos
{
   public interface IDao
    {
        public List<TipoCuenta> GetTipoCuentas();

        public List<Revenue> GetGraficoTorta();

        public List<Revenue> GetGraficoCartesiano();

        public bool SaveCliente(Cliente oCliente);

        public int NextNumCliente();

        public List<Cliente> GetByFilters(List<Parametro> criterios);

<<<<<<< HEAD
        public int GetByFiltersAdmins(Administrador oAdmin);
=======
        public bool SaveBajaCliente(int numeroClte);
        bool SaveTipoCuenta(TipoCuenta oTipo);
>>>>>>> 151c935bd463926ed2a15b82561675f1a488d9ee
    }
}
