namespace DesignPatterns.Utils
{
    public class Helpers
    {

        public static void Escolhas(string titulo, string descricao, Action<string> escolhasSwitch)
        {
            Console.WriteLine(titulo);

            for (; ; )
            {
                Console.Write("\x1b[2J\x1b[H");

                Console.WriteLine(descricao);

                string? opcao = Console.ReadLine();

                if (!string.IsNullOrEmpty(opcao))
                {
                    escolhasSwitch(opcao);

                    Console.WriteLine("\n\nPressione alguma tecla para continuar");
                    Console.ReadKey();
                }
            }


        }

    }
}
