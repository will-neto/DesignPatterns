using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Facade.Exemplo1
{
    // Subsistema 1
    internal class NotificacaoEmailService
    {
        public void ConfirmarPagamento(Compra compra)
        {
            Console.WriteLine($"Enviando e-mail para [{compra.Email}] de pagamento confirmado");
        }
    }
}
