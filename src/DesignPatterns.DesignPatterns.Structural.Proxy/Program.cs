using DesignPatterns.DesignPatterns.Structural.Proxy.Exemplo1;
using DesignPatterns.Utils;

namespace DesignPatterns.DesignPatterns.Structural.Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helpers.Escolhas(
                        "== Proxy ==",
                        "Selecione a opção \n 1 - Proxy \n 2 - Proxy apenas Composição",
                        (opcao) => {
                            switch (opcao)
                            {
                                case "1":
                                    Proxy(); break;
                                case "2":
                                    ProxyApenasComposicao(); break;
                                default:
                                    Console.WriteLine("Opção inválida"); break;
                            }
                        });
        }

        private static void Proxy()
        {
            IPagamentoService pagamentoLogService = new PagamentoLogService(new PagamentoService());

            var pagamento = new Pagamento()
            {
                Usuario = "Paul McCartney",
                Total = (decimal) 10032.33
            };

            pagamentoLogService.Pagar(pagamento);
        }

        private static void ProxyApenasComposicao()
        {

        }

    }
}
