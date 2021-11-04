
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

        public List<Revenue> ConsultarDashboard();

        public bool RegistrarCliente(Cliente oCliente);

        public int ProximoNroCliente();

        public List<Cliente> ConsultarClientes(List<Parametro> criterios);

        public int ConsultarAdmins(Administrador oAdmin);

        public Administrador ObtenerAdminByNro(int idAdmin);

        public bool RegistrarBajaCliente(int numeroClte);

        public bool RegistrarTipoCuenta(TipoCuenta oTipo);

        public Cliente ObtenerClienteByNro(int nro);

        public bool ActualizarCliente(Cliente oCliente);

    }


}
