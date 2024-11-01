using DesignPatterns.DesignPatterns.Structural.Adapter.Exemplo1;
using DesignPatterns.Utils;

namespace DesignPatterns.DesignPatterns.Structural.Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helpers.Escolhas(
                    "== Adapter ==",
                    "Selecione a opção \n 1 - Adapter",
                    (opcao) => {
                        switch (opcao)
                        {
                            case "1":
                                Adapter(); break;
                            default:
                                Console.WriteLine("Opção inválida"); break;
                        }
                    });
        }

        private static void Adapter()
        {
            // Cliente
            // Responsavel pela logica de negocio, podendo ser uma classe de serviço nova ou um trecho de um processo
            // Instancia o adapter e orquestra a chamada do serviço via adapter
            
            IPagamento pagamento = new PagamentoAdapter();

            pagamento.RealizarPagamento("R$", (decimal) 1000.33);

        }
    }
}
