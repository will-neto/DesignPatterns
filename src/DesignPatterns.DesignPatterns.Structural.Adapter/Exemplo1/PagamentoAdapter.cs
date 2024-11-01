using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Adapter.Exemplo1
{
    // Adapter
    // Classe que implementa o Target
    // Faz a adaptacao do codigo de entrada do cliente (Client) para o codigo que o legado (Adaptee) espera receber
    internal class PagamentoAdapter : IPagamento
    {
        private readonly ServicoPagamentoAntigo _servicoPagamentoAntigo;

        public PagamentoAdapter()
        {
            _servicoPagamentoAntigo = new ServicoPagamentoAntigo();
        }

        public void RealizarPagamento(string moeda, decimal valor)
        {
            var valorConvertido = $"{moeda} {valor}";
            _servicoPagamentoAntigo.RealizarPagamento(valorConvertido);
        }
    }
}
