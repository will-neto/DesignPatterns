using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObjectRelationships.Associacao
{
    internal class Tinta
    {
        public string Cor { get; set; }

        public Tinta(string cor)
        {
            Cor = cor;
        }
    }
}
