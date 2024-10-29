namespace DesignPatterns.DesignPatterns.Creational.Singleton
{
    // Usando o conceito de Eager Initialization - inicialização quando o sistema/aplicação inicia, ou seja, objeto é criado mesmo que não seja usado
    public class SingletonEager
    {
        private static readonly SingletonEager _instancia = new SingletonEager();

        private SingletonEager() { }

        public static SingletonEager Instancia => _instancia;
    }
}
