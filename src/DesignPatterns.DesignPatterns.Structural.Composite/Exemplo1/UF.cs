using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Composite.Exemplo1
{
    internal class UF : IArrecadacao
    {
        public decimal Total { get => ArrecadarImpostos(); }
        public string Nome { get; set; }

        public UF(string nome)
        {
            Nome = nome;
        }

        public decimal ArrecadarImpostos()
        {
            // Logica que recupera a arrecadacao de impostos para o Estado

            switch (this.Nome)
            {
                case "São Paulo": return 518819154;
                case "Rio de Janeiro": return 194874562;
                default: return 0;
            }
        }
    }
}
