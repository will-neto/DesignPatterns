using DesignPatterns.Utils;

namespace DesignPatterns.ConvarianceContravariance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variância é empregada em interfaces e delegates
            // Amplia o Principio de Substituição de Objetos
            // Interfaces genéricas podem produzir (via retorno de métodos) ou consumir (via parâmetros) objetos

            Helpers.Escolhas(
                "== Convariância e Contravariânci ==",
                "Selecione a opção \n 1 - Covariância \n 2 - Contravariância",
                (opcao) => {
                    switch (opcao)
                    {
                        case "1":
                            Covariancia(); break;
                        case "2":
                            Contravariancia(); break;
                        default:
                            Console.WriteLine("Opção inválida"); break;
                    }
                });

        }

        #region . . . Covariante . . .

        static void Covariancia()
        {
            Console.WriteLine("\nPrincipio de substituição de objeto com Covariância\n");

            /*
                O que é covariância no mundo real?

                - Covariância é um termo da física que se diz sobre causa-efeito
                    Caso a diminuição da causa diminua seu efeito ou se o aumento da causa gera um aumento no seu efeito, ou seja,
                    vão para a mesma direção, é usado o termo covariância

                O que é covariância no CSharp?

                - Uma extensão do uso de polimorfismo com tipos genéricos
                - A covariância permite que um tipo filho (mais derivado) seja usado onde um tipo base (mais genérico) é esperado.
                - A covariância só pode ser usada com interfaces ou delegates que retornam tipos genéricos.
                - Sua habilitação se faz através do operador "out" junto com o parâmetro de tipo (que define um tipo genérico)
                - Após habilitação da covariância, o tipo só pode ser usado em retornos de métodos ou propriedades, nunca como parâmetro no métodos
            
                Raciocine!

                - "Mas a herança/polimorfismo já não é um tipo de covariancia? Já que podemos passar um tipo mais derivado no lugar
                  de um tipo mais genérico? Por exemplo:

                        public class Base { ... }
                        public class Derivada : Base { ... }

                    
                        ... 
                        public void MetodoExemplo(Base base) {
                            ... bloco de código
                        }
                        ...

                        MetodoExemplo(new Derivada());
            
                    Dado exemplo acima, tudo funcionaria corretamente, já que a classe Derivada herda da Base.

                    >> PORÉM, PARA TIPOS GENÉRICOS, ESSE TIPO DE COMPORTAMENTO NÃO É POSSÍVEL POR PADRÃO
                    >> POR ISSO A COVARIÂNCIA EM GENÉRICOS É UMA EXTENSÃO E DEVE SER HABILITADA

             */

            // O comportamento abaixo dispara um erro quando tentamos atribuir o listaString para listaObject,
            // apesar do tipo "string" ser um tipo de "object"

            List<string> listaString = new List<string>();
            // List<object> listaObject = listaString;

            // Porém, para o exemplo abaixo é possível, tendo em vista que IEnumerable é uma interface que possui a covariância habilitada
            IEnumerable<string> strings = new List<string>();
            IEnumerable<object> objects = strings; // Covariância permite esta atribuição


            Console.WriteLine("\n\nRESUMO FINAL");
            // RESUMO FINAL

            // Correto: Possível porque os tipos são iguais | Base : Base
            IProdutorCovariante<Base> exemplo1 = new ProdutorCovariante<Base>();
            exemplo1.Produzir();

            // Correto: Possível porque os tipos são iguais | Derivada : Derivada
            IProdutorCovariante<Derivada> exemplo2 = new ProdutorCovariante<Derivada>();
            exemplo2.Produzir();

            // Correto: Permitido devido à covariância.
            // A variável "exemplo3" tem conhecimento apenas dos membros de Base, mesmo que a instância seja de Derivada | Base : Derivada
            IProdutorCovariante<Base> exemplo3 = new ProdutorCovariante<Derivada>();
            exemplo3.Produzir();

            // Inválido: A covariância não permite que um tipo mais genérico (Base) substitua um tipo mais específico (Derivada),
            // Pois "exemplo4" espera um Derivada, que pode ter membros que não existem em Base | Base : Derivada
            // IProdutorCovariante<Derivada> exemplo4 = new ProdutorCovariante<Base>();  

            // Apesar dos erros de compilação, a evidência se traz dentro dos métodos que retornam o tipo genérico
        }

        interface IProdutorCovariante<out T> // Através de "out" indicamos que o tipo "T" é covariante
        {
            T Produzir(); // A covariância é valida apenas em retornos de métodos ou propriedades

            /*
                Se T fosse usado como parâmetro de entrada em um método (void Consumir(T item)), poderíamos tentar passar um tipo base 
                (como object) para um parâmetro que espera um tipo derivado (como string), causando erros se o método Consumir() dependesse
                de alguma propriedade ou método restrito ao tipo "string".
                Ao usar out, o compilador garante que T só seja usado como saída, o que evita conflitos e mantém a segurança.       
             */
            // ERRO COMPILADOR
            // Consumir(T param);

        }

        class ProdutorCovariante<T> : IProdutorCovariante<T> where T : new()
        {
            public T Produzir()
            {
                Console.WriteLine("Criando objeto: " + this.GetType());
                return new T();
            }
        }

        #endregion



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

            // Inválido: Não é possível devido chamadas de métodos de ConsumidorContravariante<Derivada> poder possuir campos não visiveis ao tipo Base
            // IConsumidorContravariante<Base> s = new ConsumidorContravariante<Derivada>();

            r.Consumir(new Derivada());


            // Apesar dos erros de compilação, a evidência se traz nos métodos que aguardam tipos genéricos em parâmetros
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
    }

}
