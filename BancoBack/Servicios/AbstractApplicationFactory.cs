using AppBanco.Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBack.Servicios
{
    public abstract class AbstractApplicationFactory
    {
        public abstract IAplicacion CrearAplicacion(AbstractDaoFactory factory);
    }
}
