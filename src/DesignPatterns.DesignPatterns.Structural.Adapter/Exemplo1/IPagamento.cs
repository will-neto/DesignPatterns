using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Adapter.Exemplo1
{
    // Target
    // Interface com os metodos que serao adaptados
    // Os metodos sao usados pelo Client
    internal interface IPagamento
    {
        void RealizarPagamento(string moeda, decimal valor);
    }
}
