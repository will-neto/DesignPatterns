using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Prototype.Exemplo3
{
    public class Estilo : EstiloPrototipo
    {

        public Estilo(Guid id, string cabelo, string cor, string sexo, string altura) : base(id, cabelo, cor, sexo, altura)
        {
        }

        public Estilo(Estilo estilo) : base(estilo)
        {

        }


        public override EstiloPrototipo Clone()
        {
            return new Estilo(this);
        }
    }
}
