using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Adapter.Exemplo1
{
    // Adaptee (Adaptado)
    // Classe com codigo legado
    internal class ServicoPagamentoAntigo
    {
        internal void RealizarPagamento(string valor)
        {
            // Em simulacao, o servico de pagamento antigo define o valor a ser pago esperando receber um valor string
            // que possua o codigo da moeda e valor monetario juntos
            var itens = valor.Split(" ");
            Console.WriteLine($"Realizar o pagamento de {itens[0]} {itens[1]}");
        }

    }
}
