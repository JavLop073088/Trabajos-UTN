
using BancoBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBack.Servicios
{
    public interface IAplicacion
    {
        public List<TipoCuenta> ConsultarTipos();

        public List<Revenue> ConsultarGraficoTorta();

        public List<Revenue> ConsultarGraficoCartesiano();

        public bool RegistrarCliente(Cliente oCliente);

        public int ProximoNroCliente();

        public List<Cliente> ConsultarClientes(List<Parametro> criterios);

        public int ConsultarAdmins(Administrador oAdmin);

        public bool RegistrarBajaCliente(int numeroClte);

        public bool RegistrarTipoCuenta(TipoCuenta oTipo);

<<<<<<< HEAD
        public Cliente ObtenerClienteByNro(int nro);
=======
>>>>>>> 1f0bafeac1843146325c94e0603c44d14ca062d8
    }
}
