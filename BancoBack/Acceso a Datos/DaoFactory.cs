using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco.Acceso_a_Datos
{
    public class DaoFactory : AbstractDaoFactory
    {
        public override IDao CrearClienteDao()
        {
            return new ClienteDao();
        }
    }
}
