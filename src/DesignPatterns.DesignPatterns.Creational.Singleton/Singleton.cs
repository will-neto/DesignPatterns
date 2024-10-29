namespace DesignPatterns.DesignPatterns.Creational.Singleton
{
    // Classe responsável pela inicialização
    // Usando o conceito de Lazy Initialization - inicialização quando se é realmente necessário, ou seja, quando se é chamado
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
}
