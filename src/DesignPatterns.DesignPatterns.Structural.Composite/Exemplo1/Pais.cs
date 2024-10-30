using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Composite.Exemplo1
{
    internal class Pais : IArrecadacao
    {
        private IList<IArrecadacao> Arrecadacoes { get; set; }
        public string Nome { get; set; }
        public decimal Total { get => ArrecadarImpostos(); }

        public Pais(string nome)
        {
            Nome = nome;
            Arrecadacoes = new List<IArrecadacao>();
        }

        public decimal ArrecadarImpostos()
        {
            decimal total = 0;

            foreach(var arrecacao in Arrecadacoes)
            {
                total += arrecacao.ArrecadarImpostos();
            }

            return total;
        }

        public void Adicionar(IArrecadacao arrecadacao)
        {
            Arrecadacoes.Add(arrecadacao);
        }

        public void Remover(IArrecadacao arrecadacao)
        {
            Arrecadacoes.Remove(arrecadacao);
        }

        public IList<IArrecadacao> ObterArrecadacoes()
        {
            return Arrecadacoes;
        }
    }
}
