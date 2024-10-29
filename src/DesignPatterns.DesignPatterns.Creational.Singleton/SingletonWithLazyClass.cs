namespace DesignPatterns.DesignPatterns.Creational.Singleton
{
    // Exemplo usando classe nativa do .NET com controle de inicialização preguiçosa e garantida (thread-safe)
    // Usando o conceito de Lazy Initialization - inicialização quando se é realmente necessário, ou seja, quando se é chamado
    internal class SingletonWithLazyClass
    {
        // 
        private static readonly Lazy<SingletonWithLazyClass> _instancia = new Lazy<SingletonWithLazyClass>(() => new SingletonWithLazyClass());

        private SingletonWithLazyClass() { }

        public static SingletonWithLazyClass ObterInstancia()
        {
            return _instancia.Value;
        }
    }
}
