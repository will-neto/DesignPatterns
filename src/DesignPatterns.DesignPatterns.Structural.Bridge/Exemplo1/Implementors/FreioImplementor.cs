using DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Implementors
{
    internal class FreioImplementor : IPecaImplementor
    {
        public void Executar(Automovel automovel)
        {
            if (automovel.FreioABS)
                Console.WriteLine("Freiando sem travar as rodas!!");
            else
                Console.WriteLine("Freiando com trave nas rodas!!");
        }
    }
}
