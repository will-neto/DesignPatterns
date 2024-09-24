using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Prototype.Exemplo3
{
    public abstract class EstiloPrototipo
    {
        public Guid Id { get; set; }
        public string Cabelo { get; set; }
        public string Cor { get; set; }
        public string Sexo { get; set; }
        public string Altura { get; set; }

        public EstiloPrototipo(Estilo estilo)
        {
            Id = estilo.Id;
            Cabelo = estilo.Cabelo;
            Cor = estilo.Cor;
            Sexo = estilo.Sexo;
            Altura = estilo.Altura;
        }

        public EstiloPrototipo(Guid id, string cabelo, string cor, string sexo, string altura)
        {
            Id = id;
            Cabelo = cabelo;
            Cor = cor;
            Sexo = sexo;
            Altura = altura;
        }


        public abstract EstiloPrototipo Clone();
    }
}
