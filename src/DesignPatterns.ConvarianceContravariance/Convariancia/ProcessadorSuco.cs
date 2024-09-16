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

        public T FazerSuco()
        {
            if (_item != null && typeof(Fruta).IsAssignableFrom(_item.GetType()))
            {
                var fruta = _item as Fruta;

                fruta.Processada = true;

                Console.WriteLine("Fazendo suco de: " + _item.GetType().Name);
            }

            return _item;
        }
    }
}
