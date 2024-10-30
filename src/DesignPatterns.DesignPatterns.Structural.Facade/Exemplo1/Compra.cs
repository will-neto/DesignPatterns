using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Facade.Exemplo1
{
    public class Compra
    {
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public string DadosPagamento { get; set; }
        public string Email { get; set; }
    }
}
