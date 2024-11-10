using DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Domain;
using DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Implementors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Abstraction
{
    public class AutomovelAbstraction
    {
        protected IPecaImplementor _pecaImplementor;

        public AutomovelAbstraction(IPecaImplementor pecaImplementor)
        {
            _pecaImplementor = pecaImplementor;
        }

        public void Executar(Automovel automovel)
        {
            _pecaImplementor.Executar(automovel);
        }

        public void AlterarPecaImplementor(IPecaImplementor pecaImplementor)
        {
            _pecaImplementor = pecaImplementor;
        }
    }
}
