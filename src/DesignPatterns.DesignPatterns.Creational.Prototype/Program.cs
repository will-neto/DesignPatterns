using DesignPatterns.DesignPatterns.Creational.Prototype.Exemplo1;
using DesignPatterns.DesignPatterns.Creational.Prototype.Exemplo2;

namespace DesignPatterns.DesignPatterns.Creational.Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Prototype ==");

            for (; ; )
            {
                Console.Write("\x1b[2J\x1b[H");

                Console.WriteLine("Selecione a opção \n 1 - Estrutura Padrão \n 2 - ICloneable");

                string? relacionamento = Console.ReadLine();

                if (!string.IsNullOrEmpty(relacionamento))
                {
                    switch (relacionamento)
                    {
                        case "1":
                            EstruturaPadrao(); break;
                        case "2":
                            UsoDeICloneable(); break;
                        default:
                            Console.WriteLine("Opção inválida"); break;
                    }

                    Console.WriteLine("\n\nPressione alguma tecla para continuar");
                    Console.ReadKey();
                }
            }
        }

        public static void EstruturaPadrao()
        {
           
            Console.WriteLine("\nExemplo 1 - Estrutura padrão");

            Pessoa professor = new Professor("Jubileu", "Matematica");
            Pessoa professor2 = new Professor("Maria", "Portugues");
            Pessoa professor3 = professor.Clone();

            Pessoa professor4 = new Professor((Professor)professor2);

            IList<Pessoa> pessoas = new List<Pessoa>() { professor, professor2, professor3, professor4 };

            pessoas.ToList().ForEach(p => p.Apresentar());
        }
        public static void UsoDeICloneable()
        {
            Console.WriteLine("\nExemplo 2 - Estrutura padrão");

            Banana banana = new Banana("Nanica");
            banana.Bananaaaaas();
        }


    }


}
