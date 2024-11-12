using DesignPatterns.DesignPatterns.Structural.Decorator.Exemplo1;
using DesignPatterns.DesignPatterns.Structural.Decorator.Exemplo1.Decorator;
using DesignPatterns.Utils;

namespace DesignPatterns.DesignPatterns.Structural.Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helpers.Escolhas(
                "== Decorator ==",
                "Selecione a opção \n 1 - Decorator",
                (opcao) => {
                    switch (opcao)
                    {
                        case "1":
                            DecoratorExemplo(); break;
                        default:
                            Console.WriteLine("Opção inválida"); break;
                    }
                });

        }

        private static void DecoratorExemplo()
        {
            IDocumento documento = new Documento();

            documento = new CabecalhoDecorator(documento);
            documento.AdicionarComponente("Informações do Cabeçalho");

            documento = new TabelaDecorator(documento);
            documento.AdicionarComponente("Informações da Tabela");

            documento = new RodapeDecorator(documento);
            documento.AdicionarComponente("Informações do Rodapé");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine(documento.Conteudo);
        }

    }
}
