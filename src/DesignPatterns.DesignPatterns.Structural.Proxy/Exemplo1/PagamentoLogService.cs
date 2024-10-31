using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Proxy.Exemplo1
{
    // (3) Classe proxy
    // Implementa a classe de serviço
    internal class PagamentoLogService : IPagamentoService
    {
        // Composição da classe original concreta do serviço
        private readonly IPagamentoService _pagamentoService;

        public PagamentoLogService(IPagamentoService pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }

        // Operacao de proxy
        public void Pagar(Pagamento pagamento)
        {
            // Operacao usada no proxy antes da chamada do processo desejado original
            SalvarLogPagamento(pagamento);

            // Operacao original
            _pagamentoService.Pagar(pagamento);
        }

        private void SalvarLogPagamento(Pagamento pagamento)
        {
            Console.WriteLine($"[{DateTime.Now}] - Chama de serviço de pagamento [{pagamento.Usuario} - R$ {pagamento.Total.ToString("C")}]");
        }
    }
}
