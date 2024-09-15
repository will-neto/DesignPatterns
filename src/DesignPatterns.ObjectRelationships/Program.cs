using DesignPatterns.ObjectRelationships.Associacao;
using DesignPatterns.ObjectRelationships.Dependencia;

namespace DesignPatterns.ObjectRelationships
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (; ; )
            {
                Console.Write("\x1b[2J\x1b[H");

                Console.WriteLine("Selecione a opção \n 1 - Dependência \n 2 - Agregação");

                string? relacionamento = Console.ReadLine();

                if (!string.IsNullOrEmpty(relacionamento))
                {
                    switch (relacionamento)
                    {
                        case "1":
                            Dependencia(); break;
                        case "2":
                            Associacao(); break;
                        default:
                            Console.WriteLine("Opção inválida"); break;
                    }

                    Console.WriteLine("\n\nPressione alguma tecla para continuar");
                    Console.ReadKey();
                }
            }

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
                A dependência é transitória, desta forma, não é mantida uma instância de um objeto da classe B (Universidade) dentro da classe A (Aluno)
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
                Uma classe A (Pintor - cliente/dependente) depende de uma classe B (Tinta- provedor/fornecedor)
                Qualquer alteração na classe B (Tinta) pode afetar algum comportamento (processo/método) da classe A (Pintor)
                Os objetos das classe A e B podem existir sem a necessidade do outro
            
                =============================
                A dependência é contínua, desta forma, é mantida uma instância de um objeto da classe B (Tinta) dentro da classe A (Pintor)
                =============================
             */
        }
    }
}
