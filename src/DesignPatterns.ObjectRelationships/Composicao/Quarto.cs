using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObjectRelationships.Composicao
{
    internal class Quarto
    {
        public Guid Id { get; }
        public string Descricao { get; set; }

        private Casa _casa;
        public Casa Casa => _casa;


        public Quarto(String descricao, Casa casa)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
            _casa = casa ?? throw new ArgumentNullException(nameof(casa));
        }


    }
}
