using DesignPatterns.DesignPatterns.Structural.Facade.Exemplo1;
using DesignPatterns.Utils;

namespace DesignPatterns.DesignPatterns.Structural.Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helpers.Escolhas(
                "== Facade ==",
                "Selecione a opção \n 1 - Facade \n 2 - Facade com Facade Adicional",
                (opcao) => {
                    switch (opcao)
                    {
                        case "1":
                            Facade(); break;
                        case "2":
                            FacadeAdicional(); break;
                        default:
                            Console.WriteLine("Opção inválida"); break;
                    }
                });

        }

        // Cliente
        private static void Facade()
        {
            // Facade / Fachada
            // Fornece uma "interface" para simplificar a chamada de processos de código terceiro (subsistemas - bibliotecas, APIs, frameworks ou
            // módulos complexos)

            Compra compra = new Compra()
            {
                ProdutoId = 12,
                Quantidade = 1,
                DadosPagamento = "4564 4564 4564 4564 | 123 | 01/12 | Jurisbeu Derpson",
                Email = "jurisbeu@outlook.com",
                Valor = 1399.99
            };

            // Todo o processo de compra é centralizado na Facade
            // Não é necessário atribuir o sufixo "-Facade" no nome da Classe
            ProcessoDeCompraFacade processoCompraFacade = new ProcessoDeCompraFacade();

            if (processoCompraFacade.ProcessarCompra(compra))
            {
                Console.WriteLine("Compra realizada com sucesso. Verifique seu e-mail para mais detalhes!");
            }


        }

        private static void FacadeAdicional()
        {

        }
    }
}
