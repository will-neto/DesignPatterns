using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConvarianceContravariance.Convariancia
{
    internal interface IProcessadorSuco<out T>
    {
        T FazerSuco();

        // Não é possivel atribuir a covariancia em parametros de metodos, pois esse tipo de ação é usado em contravariancia
        // void FazerSuco(T result); 
    }
}
