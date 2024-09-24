using DesignPatterns.ObjectRelationships.Agregacao;
using DesignPatterns.ObjectRelationships.Associacao;
using DesignPatterns.ObjectRelationships.Composicao;
using DesignPatterns.ObjectRelationships.Dependencia;
using DesignPatterns.Utils;

namespace DesignPatterns.ObjectRelationships
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Helpers.Escolhas(
               "== Relacionamento de Objetos ==",
               "Selecione a opção \n 1 - Dependência \n 2 - Agregação \n 3 - Composição \n 4 - Agregação",
               (opcao) => {
                   switch (opcao)
                   {
                       case "1":
                           Dependencia(); break;
                       case "2":
                           Associacao(); break;
                       case "3":
                           Composicao(); break; // UMA COMPOSIÇÃO É UMA AGREGAÇÃO. POREM, A EXPLICAÇÃO VEIO ANTES DEVIDO A NECESSIDADE DE REFORÇAR O CONCEITO DE "TODO/PARTE"
                       case "4":
                           Agregacao(); break;
                       default:
                           Console.WriteLine("Opção inválida"); break;
                   }
               });
           
        }

        private static void Dependencia()
        {
            Console.WriteLine("== Dependência ==");

            Aluno aluno = new Aluno("Pedrinho");
            aluno.IrParaUniversidade();
            Universidade.AlterarStatus(UniversidadeStatus.Fechada);
            aluno.IrParaUniversidade();

            /*
                Uma classe A (Aluno - cliente/dependente) depende de uma classe B (Universidade- provedor/fornecedor)
                Qualquer alteração na classe B (Universidade) pode afetar algum comportamento (processo/método) da classe A (Aluno)
                Os objetos das classe A e B podem existir sem a necessidade do outro
            
                =============================
                A dependência com a classe B é transitória, desta forma, não é mantida uma instância de um objeto da classe B (Universidade) dentro da classe A (Aluno)
                =============================
             */
        }

        private static void Associacao()
        {
            Console.WriteLine("== Associação ==");

            Pintor aluno = new Pintor("Peixoto");
            Tinta tinta1 = new Tinta("Vermelha");
            Tinta tinta2 = new Tinta("Verde");
            Tinta tinta3 = new Tinta("Azul");

            aluno.AdicionarTinta(tinta1);
            aluno.AdicionarTinta(tinta2);
            aluno.AdicionarTinta(tinta3);

            aluno.VerificaTintas();

            tinta1.Cor = "Amarela";

            aluno.VerificaTintas();


            /*
                É um tipo de dependência

                Uma classe A (Pintor - cliente/dependente) depende de uma classe B (Tinta- provedor/fornecedor)
                Qualquer alteração na classe B (Tinta) pode afetar algum comportamento (processo/método) da classe A (Pintor)
                Os objetos das classe A e B podem existir sem a necessidade do outro
            
                =============================
                A dependência com a classe B é contínua, desta forma, é mantida uma instância de um objeto da classe B (Tinta) dentro da classe A (Pintor)
                =============================
             */
        }
   
        private static void Composicao()
        {
            Console.WriteLine("== Composição ==");

            Casa casa = new Casa("Rua dos Juribeus");
            casa.AdicionarQuarto("Quarto de casal com suíte");
            casa.AdicionarQuarto("Quarto dos filhos");
            casa.AdicionarQuarto("Quarto de hóspedese");

            casa.ExibirDetalhes();

            /*
                É um tipo de agregação ( que também é um tipo de associação )

                Uma classe A (Casa - cliente/dependente) depende de uma classe B (Quarto - provedor/fornecedor)
                Qualquer alteração na classe B (Quarto) pode afetar algum comportamento (processo/método) da classe A (Casa)
                Objeto A sabe sobre objeto B, consiste de B e gerencia o ciclo de vida de B

                Adota a relação "todo/parte", sendo "todo" a Casa e "parte" o Quarto
                A Casa (A) não depende de um quarto (B) para existir (no contexto da programação)
                O Quarto (B) depende de uma casa (A) para existir
                A destruição de um objeto casa (A), implica na destruição do objeto quarto (B). Desta forma, objeto A gerencia o ciclo de vida de B
             */
        }


        private static void Agregacao()
        {
            Console.WriteLine("== Agregação ==");

            // A utilização da mesma estrutura usada na Composição foi apenas para reforçar o conceito de todo/parte
            // Foco deve ser dado a "Casa e Piscina"

            Casa casa = new Casa("Rua dos Juribeus");

            Piscina piscina = new Piscina("Piscina linda de 40m2");

            casa.AdicionarPiscina(piscina);

            casa.ExibirDetalhes();

            casa = null;

            Console.WriteLine($"A piscina \"{piscina.Descricao}\" ainda existe e não possui casa \"{piscina.Casa}\" associada");


            /*
                É um tipo de associação ( que também é um tipo de dependência )

                Uma classe A (Casa - cliente/dependente) depende de uma classe B (Piscina - provedor/fornecedor)
                Qualquer alteração na classe B (Piscina) pode afetar algum comportamento (processo/método) da classe A (Casa)
                Objeto A sabe sobre objeto B, consiste de B e NÃO gerencia o ciclo de vida de B

                Adota a relação "todo/parte", sendo "todo" a Casa e "parte" o Piscina
                A Casa (A) não depende de uma piscina (B) para existir (no contexto da programação)
                A Piscina (B) não depende de uma casa (A) para existir
                A destruição de um objeto casa (A), NÃO implica na destruição do objeto piscina (B). Desta forma, objeto A NÃO gerencia o ciclo de vida de B

                O CÓDIGO DE UMA AGREGAÇÃO É BEM SEMELHANTE A UMA ASSOCIAÇÃO
                O QUE DIFERE É O CONCEITO DE "TODO/PARTE"
             */
        }

    }
}
