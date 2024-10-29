using DesignPatterns.DesignPatterns.Creational.Builder.Exemplo1;
using DesignPatterns.Utils;

namespace DesignPatterns.DesignPatterns.Creational.Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helpers.Escolhas(
                "== Builder ==",
                "Selecione a opção \n 1 - Builder - sem Diretor \n 2 - Builder - com Diretor",
                (opcao) => {
                    switch (opcao)
                    {
                        case "1":
                            BuilderSemDiretor(); break;
                        case "2":
                            BuilderComDiretor(); break;
                        default:
                            Console.WriteLine("Opção inválida"); break;
                    }
                });
        }


        private static void BuilderSemDiretor()
        {

            ICasaBuilder builder = new CasaPedraBuilder();
            builder.Inicializar();
            builder.Quartos(3);
            builder.Banheiros(2);
            builder.Portas(7);
            var casa = builder.Obter();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(casa);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\n\n");
            builder = new CasaMadeiraBuilder();
            builder.Inicializar();
            builder.Quartos(3);
            builder.Banheiros(2);
            builder.Portas(7);
            casa = builder.Obter();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(casa);
            Console.ForegroundColor = ConsoleColor.Gray;

        }

        private static void BuilderComDiretor()
        {
        }

    }
}
