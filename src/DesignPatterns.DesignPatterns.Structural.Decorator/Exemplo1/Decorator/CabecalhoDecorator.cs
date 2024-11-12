using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Decorator.Exemplo1.Decorator
{
    public class CabecalhoDecorator : DocumentoDecorator
    {
        public CabecalhoDecorator(IDocumento documento) : base(documento) { }

        public override void AdicionarComponente(string componente)
        {
            documento.AdicionarComponente(componente);
        }
    }
}
