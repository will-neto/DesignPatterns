using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Proxy.Exemplo1
{
    // (1) Interface comum de serviço
    // Implementada pela classe original e pelo proxy com as operações necessarias para substituir
    internal interface IPagamentoService
    {
        void Pagar(Pagamento pagamento);
    }
}
