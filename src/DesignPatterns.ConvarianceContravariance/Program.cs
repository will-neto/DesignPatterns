namespace DesignPatterns.ConvarianceContravariance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variância é empregada em interfaces e delegates
            // Amplia o Principio de Substituição de Objetos
            // Interfaces genéricas podem produzir (via retorno de métodos) ou consumir (via parâmetros) objetos

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
            Console.WriteLine("Principio de substituição de objeto com tipos regulares\n");

            /*
                No conceito de herança a atribuição de uma classe derivada a uma referência de classe base é válida por padrão
                A referência é do tipo "Base", mas a instância é do tipo "Derivada"

                Lembrando que referência é o tipo da variável que aponta para um objeto na memória. 
                O tipo da variável determina quais operações e métodos de instância são acessíveis.
                Já a instância é o tipo do objeto real, sendo a representação concreta do tipo em memória.
            */

            // Válido
            Base classeBase = new Base();
            // Válido
            Base classeDerivada = new Derivada();

            classeBase.Mensagem();
            classeDerivada.Mensagem();

            // Não é possível fazer a instância de um tipo mais genérico em uma variável de tipo mais específico
            // Inválido
            // Derivada classeDerivadaInvalida = new Base();

            Console.WriteLine("\nPrincipio de substituição de objeto com Covariância\n");

            // Covariância é um termo da física que se diz sobre causa-efeito
            // Caso a diminuição da causa diminui o efeito, ou seja, vão para a mesma direção, é usado o termo covariância

            // A covariância na programação é usada de forma efetiva com o principio de substituição de objeto + classes genéricas
            // A covariância só pode ser usada com métodos/propriedades que retornam tipos genéricos. Não pode ser usada com tipos genéricos em parâmetros de entrada

            IProdutorCovariante<Base> produtorBase = new ProdutorCovariante<Base>();

            Base a = produtorBase.Produzir();
            // Erro de compilação, pois a classe genérica não permite a atribuição de uma instância que retorna a Classe Base a uma que retorna Derivada
            // Derivada b = produtorBase.Produzir();


            IProdutorCovariante<Derivada> produtorDerivada = new ProdutorCovariante<Derivada>();
            Base c = produtorDerivada.Produzir();
            Derivada d = produtorDerivada.Produzir();

            a.Mensagem();
            c.Mensagem();
            d.Mensagem();

            // Permite a atribuição a variável de classe genérica Base com o tipo mais específico, classe Derivada
            // Isso se faz possível através da covariância
            produtorBase = new ProdutorCovariante<Derivada>();
            Base e = produtorBase.Produzir();

            e.Mensagem();

            // De forma resumida, o comportamento de atribuição de instância de uma subclasse a uma referência de superclasse é válida
            // Pórém, em classes genéricas não. O que se faz necessário a utilização de covariância
            // Desta forma, a covariância permite a substituição de um tipo genérico (Base) por um tipo mais específico (Derivada) na instância


            // A COVARIÂNCIA É PERMITIDA EM RETORNOS DE MÉTODOS DEVIDO SABERMOS QUAL TIPO ESPERAR
            // POR ISSO PODEMOS PASSAR UM TIPO MAIS ESPECÍFICO EM UM MÉTODO QUE RETORNA UM TIPO MAIS GERAL
            // TENDO EM VISTA QUE O TIPO MAIS ESPECÍFICO É UMA SUBCLASSE DESTE TIPO MAIS GERAL
            // DESTA FORMA, SABEMOS O QUE AGUARDAR, SEMELHANTE AO USO DE TIPOS REGULARES => Base base = new Fruta();

            // NAO PODEMOS USAR A COVARIANCIA EM PARAMETROS, POIS PERMITE QUE SEJA PASSADO UM TIPO ESPECIFICO NO LUGAR DE UM TIPO GERAL
            // DESTA FORMA, NAO SABEMOS O QUE PODE ENTRAR NO PARAMETRO, A OPERAÇÃO DO TIPO ESPECIFICO PODE FAZER CHAMADAS A PROPRIEDADES OU MÉTODOS ESPECIFICOS DA SUBCLASSE
            // O QUE OCASIONARIA UM ERRO, TENDO EM VISTA QUE A REFERENCIA QUE UTILIZA A CLASSE DA SUPERCLASSE NAO TERIA VISIBILIDADE
        }

        interface IProdutorCovariante<out T> // Através de "out" indicamos que o tipo "T" é covariante
        {
            T Produzir(); // A covariância é valida apenas em retornos de métodos ou propriedades
        }

        class ProdutorCovariante<T> : IProdutorCovariante<T> where T : new()
        {
            public T Produzir()
            {
                return new T();
            }
        }

        interface IConsumidorContravariante<in T> // Através de "in" indicamos que o tipo "T" é contravariante
        {
            void Consumir(T t);
        }

        static void Contravariancia()
        {
            Console.WriteLine("\nPrincipio de substituição de objeto com Contravariância\n");

            // Contravariância é um termo da física que se diz sobre causa-efeito
            // Caso a diminuição da causa aumenta o efeito, ou seja, vão para a direção oposta, é usado o termo contravariância

            // A Contravariância na programação é usada de forma efetiva com o principio de substituição de objeto + classes genéricas    

            // A contravariância só pode ser usada com métodos que possuem tipos genéricos em parâmetros de entradas. Não pode ser usada
            // em tipos genéricos de retornos em métodos
        
                
        }
    }

}
