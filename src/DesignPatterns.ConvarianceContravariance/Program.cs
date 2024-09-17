
using DesignPatterns.ConvarianceContravariance.Contravariancia;
using DesignPatterns.ConvarianceContravariance.Convariancia;

namespace DesignPatterns.ConvarianceContravariance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (; ; )
            {
                Console.Write("\x1b[2J\x1b[H");

                Console.WriteLine("Selecione a opção \n 1 - Covariância \n 2 - Contravariância");

                string? relacionamento = Console.ReadLine();

                if (!string.IsNullOrEmpty(relacionamento))
                {
                    switch (relacionamento)
                    {
                        case "1":
                            Covariancia(); break;
                        case "2":
                            Contravariancia(); break;
                        default:
                            Console.WriteLine("Opção inválida"); break;
                    }

                    Console.WriteLine("\n\nPressione alguma tecla para continuar");
                    Console.ReadKey();
                }
            }
        }

        static void Covariancia()
        {
          
        }

        static void Contravariancia()
        {
         

        }

    }

}
