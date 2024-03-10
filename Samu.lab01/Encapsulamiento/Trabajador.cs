using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samu.lab01.Herencia
{
       public class Trabajador
    {
        public string nombre { set; get; }
        protected int id { set; get; }     //en este caso hice un ejemplo de lo que entendí por el termino encapsulamiento, proteger datos, en este caso el id del trabajador
    }
}
