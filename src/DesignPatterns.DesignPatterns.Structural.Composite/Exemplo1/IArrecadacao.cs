using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Composite.Exemplo1
{

    // (1) Interface comum que possui as operações que as classes simples (Folhas) ou complexas (Composições) devem implementar
    public interface IArrecadacao
    {
        decimal ArrecadarImpostos();
        decimal Total { get; }
        string Nome { get; set; }
    }
}
