using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Proxy.Exemplo1
{
    // (2) Classe de serviço
    // Contem a logica original desejada pelo cliente e ela sera chamada pela classe proxy apos tratativas antes ou depois
    internal class PagamentoService : IPagamentoService
    {
        public void Pagar(Pagamento pagamento)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\nExecuta processo de pagamento para {pagamento.Usuario} no valor de R$ {pagamento.Total.ToString("C")}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
