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

        public int GetByFiltersAdmins(Administrador oAdmin);

        public bool SaveBajaCliente(int numeroClte);

<<<<<<< HEAD
        public bool SaveTipoCuenta(TipoCuenta oTipo);

        public Cliente GetByNro(int nro);
=======
        bool SaveTipoCuenta(TipoCuenta oTipo);

>>>>>>> 1f0bafeac1843146325c94e0603c44d14ca062d8
    }
}
