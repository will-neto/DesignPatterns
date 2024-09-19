using DesignPatterns.DesignPatterns.Creational.Prototype.Exemplo1;
using DesignPatterns.DesignPatterns.Creational.Prototype.Exemplo2;

namespace DesignPatterns.DesignPatterns.Creational.Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Prototype ==");


            Console.WriteLine("\nExemplo 1 - Estrutura padrão");

            Pessoa professor = new Professor("Jubileu", "Matematica");
            Pessoa professor2 = new Professor("Maria", "Portugues");
            Pessoa professor3 = professor.Clone();

            Pessoa professor4 = new Professor((Professor) professor2);

            IList<Pessoa> pessoas = new List<Pessoa>() { professor, professor2, professor3, professor4 };

            pessoas.ToList().ForEach(p => p.Apresentar());

            Console.WriteLine("\nExemplo 2 - Estrutura padrão");

            Banana banana = new Banana("Nanica");
            banana.Bananaaaaas();


        }
    }


}
