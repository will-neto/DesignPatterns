using DesignPatterns.DesignPatterns.Creational.Prototype.Exemplo1;
using DesignPatterns.DesignPatterns.Creational.Prototype.Exemplo2;
using DesignPatterns.DesignPatterns.Creational.Prototype.Exemplo3;
using DesignPatterns.Utils;

namespace DesignPatterns.DesignPatterns.Creational.Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helpers.Escolhas(
                "== Prototype ==",
                "Selecione a opção \n 1 - Estrutura Padrão \n 2 - ICloneable\n 3 - Registro de Protótipos",
                (opcao) => {
                    switch (opcao)
                    {
                        case "1":
                            EstruturaPadrao(); break;
                        case "2":
                            UsoDeICloneable(); break;
                        case "3":
                            UsoRegistroDePrototipos(); break;
                        default:
                            Console.WriteLine("Opção inválida"); break;
                    }
                });

        }

        // Exemplo padrão de utilização do padrão Prototype
        private static void EstruturaPadrao()
        {
           
            Console.WriteLine("\nExemplo 1 - Estrutura padrão");

            Pessoa professor = new Professor("Jubileu", "Matematica");
            Pessoa professor2 = new Professor("Maria", "Portugues");
            Pessoa professor3 = professor.Clone();

            Pessoa professor4 = new Professor((Professor)professor2);

            IList<Pessoa> pessoas = new List<Pessoa>() { professor, professor2, professor3, professor4 };

            pessoas.ToList().ForEach(p => p.Apresentar());
        }

        // Utilização de interface nativa ICloneable 
        private static void UsoDeICloneable()
        {
            Console.WriteLine("\nExemplo 2 - Estrutura padrão");

            Banana banana = new Banana("Nanica");
            banana.Bananaaaaas();
        }

        // Utilização de registro de prototipos
        // Permite o gerenciamento (adição/remoção/resgate) de uma lista de prototipos
        // Podem ser salvos em memoria ou resgatado pelo banco de dados
        private static void UsoRegistroDePrototipos()
        {
            Console.WriteLine("\nExemplo 3 - Registro de Prototipos");


            RegistroEstilos registro = new RegistroEstilos();

            Estilo estilo = new Estilo(Guid.NewGuid(), "Careca", "Rosa", "Masculino", "1.80");

            registro.Registrar(estilo);

            Personagem majinBoo = new Personagem(
                Guid.NewGuid(),
                "Majin Boo",
                estilo
            );

            Estilo estilo2 = (Estilo) registro.Resgatar(estilo.Id);

            estilo2.Altura = "1,98";

            Personagem superBoo = new Personagem(
                 Guid.NewGuid(),
                 "Super Boo",
                 estilo2
            );

            Estilo estilo3 = (Estilo)registro.Resgatar(estilo.Id);

            estilo3.Altura = "1,50";

            Personagem kidBoo = new Personagem(
                 Guid.NewGuid(),
                 "Kid Boo",
                 estilo3
            );


            majinBoo.Apresentar();
            superBoo.Apresentar();
            kidBoo.Apresentar();
        }
    }


}
