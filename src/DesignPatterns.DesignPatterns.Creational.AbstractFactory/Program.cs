using DesignPatterns.DesignPatterns.Creational.AbstractFactory.Exemplo1;
using DesignPatterns.Utils;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helpers.Escolhas(
                "== Abstract Factory ==",
                "Selecione a opção \n 1 - Abstract Factory",
                (opcao) => {
                    switch (opcao)
                    {
                        case "1":
                            AbstractFactorySample(); break;
                        default:
                            Console.WriteLine("Opção inválida"); break;
                    }
                });
        }

        private static void AbstractFactorySample()
        {
        
            // Exemplo de utilização das fabricas

            Entrada entrada;
            Sobremesa sobremesa;

            Restaurante restauranteBrasileiro = new RestauranteBrasileiro();
            entrada = restauranteBrasileiro.PedirEntrada();
            sobremesa = restauranteBrasileiro.PedirSobremesa();

            entrada.Solicitar();
            sobremesa.Solicitar();

            Console.WriteLine("-------------------");

            Restaurante restauranteChines = new RestauranteChines();
            entrada = restauranteChines.PedirEntrada();
            sobremesa = restauranteChines.PedirSobremesa();

            entrada.Solicitar();
            sobremesa.Solicitar();

        }


    }
}
