using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ConvarianceContravariance.Convariancia
{
    internal class ProcessadorSuco<T> : IProcessadorSuco<T> where T : new()
    {
        private T _item;

        public ProcessadorSuco(T item)
        {
            _item = item;
        }

        public void FazerSuco()
        {
            if (_item != null)
            {
                Console.WriteLine("Fazendo suco de: " + _item.GetType().Name);
            }
        }
    }
}
