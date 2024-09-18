﻿namespace DesignPatterns.DesignPatterns.Creational.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
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


            // Exemplo de uso com inicialização através de Lazy<object>

            SingletonWithLazy instanciaUnica3 = SingletonWithLazy.ObterInstancia();

            Console.WriteLine("Variável \"instanciaUnica3\" com HashCode: " + instanciaUnica3.GetHashCode());

            SingletonWithLazy instanciaUnica4 = SingletonWithLazy.ObterInstancia();

            Console.WriteLine("Variável \"instanciaUnica4\" com HashCode: " + instanciaUnica4.GetHashCode());


        }
    }

    // Classe responsável pela inicialização
    internal class Singleton
    {
        private static Singleton _instancia = null!;
        
        // Objeto auxiliar para lock. Evita disparar erro ao lockar _instancia quando estiver nula
        private static readonly object _lock = new object();

        // (1) Para garantirmos que a instância tenha apenas 1 instância, devemos limitar a criação dela através do operador "new"
        // Isso deve ser feito através do modificador de acesso "private", garantindo que nenhuma outra parte do código crie uma instância da Classe por fora dela
        private Singleton() { }
    
        // (2) A instância deve ser gerenciada através de um método estático
        // (1) O controle se faz a partir de uma instância única. Neste caso, a propriedade _instance
        public static Singleton ObterInstancia()
        {
            // Garante que uma thread de outro processo ou usuário não instância o objeto ao mesmo tempo caso ainda não tenha sido criado
            if (_instancia == null)
            {
                lock (_lock)
                {
                    if (_instancia == null)
                    {
                        _instancia =  new Singleton();
                    }
                }
            }

            return _instancia;
        }
    }


    // Exemplo usando classe nativa do .NET com controle de inicialização preguiçosa e garantida (thread-safe)
    internal class SingletonWithLazy
    {
        // 
        private static readonly Lazy<SingletonWithLazy> _instancia = new Lazy<SingletonWithLazy>(() => new SingletonWithLazy());

        private SingletonWithLazy() { }

        public static SingletonWithLazy ObterInstancia()
        {
            return _instancia.Value;
        }
    }

}