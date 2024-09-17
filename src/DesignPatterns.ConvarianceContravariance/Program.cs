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

            
            // No conceito de herança a atribuição de uma classe derivada a uma referência de classe base é válida por padrão
            // A referência é do tipo "Base", mas a instância é do tipo "Derivada"
 
            // Lembrando que referência é o tipo da variável que aponta para um objeto na memória. 
            // O tipo da variável determina quais operações e métodos de instância são acessíveis.
            // Já a instância é o tipo do objeto real, sendo a representação concreta do tipo em memória.
            

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


            Console.WriteLine("\n\nRESUMO FINAL");
            // RESUMO FINAL

            // Correto: Possível porque os tipos são iguais | Base : Base
            IProdutorCovariante<Base> p = new ProdutorCovariante<Base>();
            p.Produzir();

            // Correto: Possível porque os tipos são iguais | Derivada : Derivada
            IProdutorCovariante<Derivada> q = new ProdutorCovariante<Derivada>();
            p.Produzir();

            // Correto: Permitido devido à covariância.
            // A variável "r" tem conhecimento apenas dos membros de Base, mesmo que a instância seja de Derivada | Base : Derivada
            // 
            IProdutorCovariante<Base> r = new ProdutorCovariante<Derivada>();
            p.Produzir();

            // Inválido: A covariância não permite que um tipo mais genérico (Base) substitua um tipo mais específico (Derivada),
            // Pois "s" espera um Derivada, que pode ter membros que não existem em Base | Base : Derivada
            // IProdutorCovariante<Derivada> s = new ProdutorCovariante<Base>();  

            // Apesar dos erros de compilação, a evidência se traz dentro dos métodos que retornam o tipo genérico
        }

        interface IProdutorCovariante<out T> // Através de "out" indicamos que o tipo "T" é covariante
        {
            T Produzir(); // A covariância é valida apenas em retornos de métodos ou propriedades
        }

        class ProdutorCovariante<T> : IProdutorCovariante<T> where T : new()
        {
            public T Produzir()
            {
                Console.WriteLine("Criando objeto: " + this.GetType());
                return new T();
            }
        }

        interface IConsumidorContravariante<in T> // Através de "in" indicamos que o tipo "T" é contravariante
        {
            void Consumir(T t);
        }

        class ConsumidorContravariante<T> : IConsumidorContravariante<T> where T : new()
        {
            public void Consumir(T t)
            {
                Console.WriteLine("Chamada do método consumir via: " + t.GetType().Name);
            }
        }

        static void Contravariancia()
        {
            Console.WriteLine("\nPrincipio de substituição de objeto com Contravariância\n");

            // Contravariância é um termo da física que se diz sobre causa-efeito
            // Caso a diminuição da causa aumenta o efeito, ou seja, vão para a direção oposta, é usado o termo contravariância

            // A Contravariância na programação é usada de forma efetiva com o principio de substituição de objeto + classes genéricas    

            // A contravariância só pode ser usada com métodos que possuem tipos genéricos em parâmetros de entradas. Não pode ser usada
            // em métodos com tipo genérico no seu retorno

            // RESUMO FINAL

            // Correto: Possível, porque os tipos são iguais | Derivada : Derivada
            IConsumidorContravariante<Derivada> p = new ConsumidorContravariante<Derivada>();

            // Correto: Possível, porque os tipos são iguais | Base : Base
            IConsumidorContravariante<Base> q = new ConsumidorContravariante<Base>();

            // Correto: Permitido devido à contravariância, onde o tipo mais genérico (Base) pode ser usado onde o tipo mais específico (Derivada) é esperado | Derivada : Base
            // Pois os métodos contravariantes de ConsumidorContravariante<Derivada> podem utilizar propriedades/métodos herdados da classe base
            IConsumidorContravariante<Derivada> r = new ConsumidorContravariante<Base>();

            // IConsumidorContravariante<Base> s = new ConsumidorContravariante<Derivada>();

            r.Consumir(new Derivada());


            // Apesar dos erros de compilação, a evidência se traz nos métodos que aguardam tipos genéricos em parâmetros
        }


    }

}
