using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConvarianceContravariance
{
    internal class Base
    {
        public void Mensagem()
        {
            Console.WriteLine("Mensagem disparada através do objeto de classe: " + this.GetType().Name);
        }
    }
}
