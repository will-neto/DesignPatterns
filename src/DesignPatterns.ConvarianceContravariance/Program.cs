
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
            // Permite o uso de um tipo mais específico (out - igual ao tipo ou subclasse) no lugar de um tipo de superclasse

            /*
                Em interfaces, o uso da palavra "out" é utilizado na interface base
                Desta forma, é possível passar um tipo mais específico (subclasse)
             
             */

            var laranja = new Laranja();
            var maca = new Maca();
            var fruta = new Fruta();

            Console.WriteLine("laranja foi processada? = " + laranja.Processada);
            Console.WriteLine("maca foi processada? = " + maca.Processada);
            Console.WriteLine("fruta foi processada? = " + fruta.Processada);

            IProcessadorSuco<Fruta> processador = new ProcessadorSuco<Laranja>(laranja);
            IProcessadorSuco<Fruta> processador2 = new ProcessadorSuco<Maca>(maca);
            IProcessadorSuco<Fruta> processador3 = new ProcessadorSuco<Fruta>(fruta);

            //Erro de compilação devido a classe "Alimento" ser um tipo mais geral/generico/abstrato (in)
            //IProcessadorSuco<Fruta> processador4 = new ProcessadorSuco<Alimento>(new Alimento());

            processador.FazerSuco();
            processador2.FazerSuco();
            processador3.FazerSuco();

            Console.WriteLine("laranja foi processada? = " + laranja.Processada);
            Console.WriteLine("maca foi processada? = " + maca.Processada);
            Console.WriteLine("fruta foi processada? = " + fruta.Processada);
        }

        static void Contravariancia()
        {
            // Permite o uso de um tipo mais geral/abstrato no lugar de um tipo de subclasse

            /*
                
             */

        }

    }

}
