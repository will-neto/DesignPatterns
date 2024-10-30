using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Facade.Exemplo1
{
    // Subsistema 3
    public class PagamentoService
    {
        public bool FazerPagamento(Compra compra)
        {
            Console.WriteLine($"Realizando processo de pagamento com [{compra.DadosPagamento}]");

            return true;
        }
    }
}
