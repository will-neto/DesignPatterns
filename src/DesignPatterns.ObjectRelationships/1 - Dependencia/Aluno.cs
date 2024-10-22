using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObjectRelationships.Dependencia
{
    internal class Aluno
    {

        public string Nome { get; set; }

        public Aluno(string nome)
        {
            Nome = nome;    
        }

        public void IrParaUniversidade()
        {
            if (Universidade.Status == UniversidadeStatus.Aberta) {
                Console.WriteLine($"{Nome} está caminhando para a {Universidade.Nome}");
                return;
            }

            Console.WriteLine($"{Nome} não pode ir a {Universidade.Nome} pois está fechada");
        }
    }
}
