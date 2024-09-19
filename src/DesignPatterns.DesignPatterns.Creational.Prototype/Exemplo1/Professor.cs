using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Prototype.Exemplo1
{
    public class Professor : Pessoa
    {
        public string Materia { get; set; }

        public Professor(string nome, string materia)
        {
            Nome = nome;
            Materia = materia;
        }

        public Professor(Professor professor) : base(professor)
        {
            Materia = professor.Materia;
        }

        public override Pessoa Clone()
        {
            return new Professor(this);
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, sou {this.Nome} e leciono {this.Materia}. Meu código de registro é {this.GetHashCode()}");
        }
    }
}
