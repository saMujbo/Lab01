using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Samu.lab01.Herencia
{
    internal class TrabajadorContraato: Trabajador
    {
        public int salarioFijo { set; get;}
    }
}
