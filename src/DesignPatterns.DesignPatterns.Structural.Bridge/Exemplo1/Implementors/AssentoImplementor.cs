using DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Implementors
{
    internal class AssentoImplementor : IPecaImplementor
    {
        public void Executar(Automovel automovel)
        {
            if (automovel.Passageiros + 1 > automovel.Assentos)
                throw new InvalidOperationException("Não podemos dirigir com o número de passageiros maior que a quantidade de assentos :( !");

            Console.WriteLine("Sentando e ajustando os retrovisores!");
        }
    }
}
