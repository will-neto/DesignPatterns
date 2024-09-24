using DesignPatterns.DesignPatterns.Creational.FactoryMethod.Exemplo1;
using DesignPatterns.Utils;

namespace DesignPatterns.DesignPatterns.Creational.FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helpers.Escolhas(
                "== Prototype ==",
                "Selecione a opção \n 1 - Factory Method com Classe Abstrata \n 2 - Factory Method com Interface \n 3 - Factory Method com Interface",
                (opcao) => {
                    switch (opcao)
                    {
                        case "1":
                            FactoryMethodWithAbstractClass(); break;
                        case "2":
                            FactoryMethodWithInterface(); break;
                        case "3":
                            FactoryMethodWithNormalClass(); break;
                        default:
                            Console.WriteLine("Opção inválida"); break;
                    }
                });
        }

        private static void FactoryMethodWithAbstractClass()
        {
            // O código cliente quem utiliza a Fábrica
            PrestadoraServico prestadora;

            // Simulação de chamada a algum tipo de fabrica
            // Através desta simulação por aleatoriedade podemos provar que o Cliente (onde contém a lógica de uso do objeto)
            //  não é dependente da classe concreta da fábrica. O que diminui o baixo acoplamento, já que dependemos
            //  apenas da abstração do Produto
            var randomFabrica = new Random().Next(1, 3);
            var randomTipoCliente = new Random().Next(1, 3);

            // Obtemos uma fabrica
            if (randomFabrica == 1)
                prestadora = new PrestadoraDeLuz((TipoCliente) randomTipoCliente);
            else
                prestadora= new PrestadoraDeAgua((TipoCliente) randomTipoCliente);

            Empregado empregado = prestadora.SolicitarEmpregado();

            // Fazemos chamada ao trabalho do Empregado, sem que o código dependa da classe concreta
            // Isso flexibiliza, diminui o acoplamento e mantém nosso código com uma melhor extensibilidade de novas features
            Console.WriteLine($"[{empregado.GetType().Name} - {empregado.Tipo.ToString()}]");
            empregado.FazerTrabalho();


            // Um ponto válido é entender que apesar de encapsularmos a criação de um objeto dentro de uma classe+método apartado
            // ainda existe a necessidade de definir qual Factory Method utilizar... 
            // Porém, em minha consideração pessoal, vejo que o objetivo de centralizar o processo de criação de um objeto
            // seja o principal motivo da utilização do Factory Method. O que a longo prazo pode nos ajudar, já que não precisamos
            // atribuir a criação via "new", ainda mais em objetos que possam ter algum conjunto de regras (que neste caso, estariam
            // implementados no método da fábrica)
        }

        private static void FactoryMethodWithInterface()
        {

        }

        private static void FactoryMethodWithNormalClass()
        {

        }
    }
}
