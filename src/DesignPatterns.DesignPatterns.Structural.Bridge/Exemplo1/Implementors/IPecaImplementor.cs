using DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Implementors
{
    public interface IPecaImplementor
    {
        void Executar(Automovel automovel);
    }
}
