using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Prototype.Exemplo1
{
    // (1) Classe abstrata que serve de protótipo
    // Podemos optar pela usabilidade de uma interface também, mas temos a possibilidade e flexibilidade maior de poder
    // definir modificadores de acessos em propriedades, construtores padrões, etc...
    // O que para o padrão protótipo pode haver benefício, já que podemos encapsular a clonagem de campos padrões já no construtor da superclasse (exemplo, nome)
    public abstract class Pessoa
    {

        // Campo de exemplo que será clonado por padrão
        public string Nome { get; set; }

        // Construtor vazio para possibilitar a instância de subclasses de maneira personalizada
        public Pessoa() { }

        // Construtor importante, nele é feito o recebimento do objeto que servirá de parâmetro para clonagem.
        public Pessoa(Pessoa pessoa)
        {
            Nome = pessoa.Nome;
        }

        public abstract Pessoa Clone();

        public abstract void Apresentar();
    }
}
