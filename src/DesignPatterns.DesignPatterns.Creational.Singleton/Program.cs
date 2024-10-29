using DesignPatterns.Utils;

namespace DesignPatterns.DesignPatterns.Creational.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helpers.Escolhas(
                "== Singleton ==",
                "Selecione a opção \n 1 - Singleton \n 2 - Singleton com carregamento Lazy (Tardio)\n 3 - Singletion com carregamento Eager (antecipado)",
                (opcao) => {
                    switch (opcao)
                    {
                        case "1":
                            SingletonCall(); break;
                        case "2":
                            SingletonLazyCall(); break;
                        case "3":
                            SingletonEagerCall(); break;
                        default:
                            Console.WriteLine("Opção inválida"); break;
                    }
                });

        }

        // Singleton
        private static void SingletonCall()
        {
            // Padrão Singleton

            // (1) Garantir que uma classe tenha apenas uma instância na aplicação toda
            // (2) Fornecer um ponto de acesso global para a instância


            // Não é possível inicializar o objeto por fora da classe por ter o construtor privado
            // Singleton instancia = new Singleton();   


            // A recuperação da instância só é possível através do método estático obterInstancia()
            Singleton instanciaUnica = Singleton.ObterInstancia();

            Console.WriteLine("Variável \"instanciaUnica\" com HashCode: " + instanciaUnica.GetHashCode());

            Singleton instanciaUnica2 = Singleton.ObterInstancia();

            Console.WriteLine("Variável \"instanciaUnica2\" com HashCode: " + instanciaUnica2.GetHashCode());

        }
    
        // Singleton com classe nativa Lazy (equivalente a abordagem padrão)
        private static void SingletonLazyCall()
        {
            // Exemplo de uso com inicialização através de Lazy<object>

            SingletonWithLazyClass instanciaUnica3 = SingletonWithLazyClass.ObterInstancia();

            Console.WriteLine("Variável \"instanciaUnica3\" com HashCode: " + instanciaUnica3.GetHashCode());

            SingletonWithLazyClass instanciaUnica4 = SingletonWithLazyClass.ObterInstancia();

            Console.WriteLine("Variável \"instanciaUnica4\" com HashCode: " + instanciaUnica4.GetHashCode());

        }
    
        // Singleton com classe instância antecipada
        private static void SingletonEagerCall()
        {
            // Exemplo de uso com inicialização através de Eager

            SingletonEager instanciaUnica5 = SingletonEager.Instancia;

            Console.WriteLine("Variável \"instanciaUnica5\" com HashCode: " + instanciaUnica5.GetHashCode());

            SingletonEager instanciaUnica6 = SingletonEager.Instancia;

            Console.WriteLine("Variável \"instanciaUnica6\" com HashCode: " + instanciaUnica6.GetHashCode());

        }
    }
}
