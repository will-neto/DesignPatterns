using DesignPatterns.ObjectRelationships.Agregacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObjectRelationships.Composicao
{
    internal class Casa
    {
        private List<Quarto> _quartos = new List<Quarto>();

        private Piscina _piscina;

        public string Endereco { get; set; }

        public Casa(string endereco)
        {
            Endereco = endereco;
        }

        public void AdicionarQuarto(string descricao)
        {
            Quarto quarto = new Quarto(descricao, this);
            _quartos.Add(quarto);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Casa no endereço: {Endereco}");
            foreach (var quarto in _quartos)
            {
                Console.WriteLine($" - Quarto: {quarto.Id} - {quarto.Descricao}");
            }

            if (_piscina != null)
            {
                Console.WriteLine($" - Piscina: {_piscina.Id} - {_piscina.Descricao}");
            }
        }

        public void AdicionarPiscina(Piscina piscina)
        {
            _piscina = piscina;
        }
    }
}
