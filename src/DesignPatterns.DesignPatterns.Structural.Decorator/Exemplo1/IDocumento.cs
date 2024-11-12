using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Decorator.Exemplo1
{
    public interface IDocumento
    {
        string Conteudo { get; }
        void AdicionarComponente(string componente);
    }

}
