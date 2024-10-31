using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Proxy.Exemplo1
{
    // Classe exemplo dominio
    internal class Pagamento
    {
        public decimal Total { get; set; }
        public string Usuario { get; set; }
    }
}
