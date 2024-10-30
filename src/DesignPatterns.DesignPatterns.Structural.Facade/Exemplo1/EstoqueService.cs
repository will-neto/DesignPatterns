using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Facade.Exemplo1
{
    // Subsistema 2
    public class EstoqueService
    {
        public bool VerificarEmEstoque(Compra compra)
        {
            Console.WriteLine($"Verifica se produto [{compra.ProdutoId}] possui estoque");

            return true;
        }
    }
}
