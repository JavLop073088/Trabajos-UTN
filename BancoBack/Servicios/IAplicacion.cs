
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

<<<<<<< HEAD
        public int ConsultarAdmins(Administrador oAdmin);
=======
        public bool RegistrarBajaCliente(int numeroClte);

        public bool RegistrarTipoCuenta(TipoCuenta oTipo);
>>>>>>> 151c935bd463926ed2a15b82561675f1a488d9ee
    }
}
