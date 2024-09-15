using DesignPatterns.ObjectRelationships.Composicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObjectRelationships.Agregacao
{
    internal class Piscina
    {
        public Guid Id { get; }
        public string Descricao { get; set; }

        private Casa _casa;
        public Casa Casa => _casa;

        public Piscina(String descricao)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
        }
    }
}
