using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBack.Dominio
{
    public class Revenue
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public double Value { get; set; }

        public string Tipo { get; set; }
        public int Cantidad { get; set; }
    }
}
