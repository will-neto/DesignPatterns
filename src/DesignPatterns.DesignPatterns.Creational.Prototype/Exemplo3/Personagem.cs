using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Prototype.Exemplo3
{
    public class Personagem
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public Estilo Estilo { get; set; }

        public Personagem(Guid id, string nome, Estilo estilo)
        {
            Id = id;
            Nome = nome;
            Estilo = estilo;
        }

        public void Apresentar()
        {
            Console.WriteLine(
                " Id = " + this.Id +
                " Nome = " + this.Nome +
                " Estilo = [" +
                    " Id = " + this.Estilo.Id +
                    " Cabelo = " + this.Estilo.Cabelo +
                    " Cor = " + this.Estilo.Cor +
                    " Altura = " + this.Estilo.Altura +
                "]"
            ); ;
        }
    }
}
