using DesignPatterns.DesignPatterns.Structural.Composite.Exemplo1;
using DesignPatterns.Utils;

namespace DesignPatterns.DesignPatterns.Structural.Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helpers.Escolhas(
                "== Composite ==",
                "Selecione a opção \n 1 - Composite",
                (opcao) => {
                    switch (opcao)
                    {
                        case "1":
                            Composite(); break;
                        default:
                            Console.WriteLine("Opção inválida"); break;
                    }
                });

        }

        private static void Composite()
        {
            Pais arrecadacao = new Pais("Brasil");
            arrecadacao.Adicionar(new UF("São Paulo"));
            arrecadacao.Adicionar(new UF("Rio de Janeiro"));

            var totalImposto = arrecadacao.ArrecadarImpostos().ToString("0.00");

            Console.WriteLine($"O total de imposto recolhido para o país {arrecadacao.Nome} foi de R$ {totalImposto}");
        }
    }
}
