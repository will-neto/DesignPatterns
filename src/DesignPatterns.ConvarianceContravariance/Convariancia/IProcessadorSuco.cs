using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConvarianceContravariance.Convariancia
{
    internal interface IProcessadorSuco<out T>
    {
        void FazerSuco();
    }
}
