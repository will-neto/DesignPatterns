using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObjectRelationships.Associacao
{
    internal class Pintor
    {
        public string Nome { get; set; }
        private List<Tinta> Tintas { get; set; } = new List<Tinta>();

        public Pintor(string nome)
        {
            Nome = nome;
        }

        public void AdicionarTinta(Tinta tinta)
        {
            Tintas.Add(tinta);
        }

        public void VerificaTintas()
        {
            Console.WriteLine($"{Nome} possui as tintas {string.Join(",", Tintas.Select(e => e.Cor).Distinct())}");
        }
    }
}
