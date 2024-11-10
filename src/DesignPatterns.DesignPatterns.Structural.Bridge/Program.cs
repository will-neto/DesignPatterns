using DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Abstraction;
using DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Domain;
using DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Implementors;
using DesignPatterns.Utils;

namespace DesignPatterns.DesignPatterns.Structural.Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helpers.Escolhas(
                    "== Bridge ==",
                    "Selecione a opção \n 1 - Bridge",
                    (opcao) => {
                        switch (opcao)
                        {
                            case "1":
                                BridgeExemplo(); break;
                            default:
                                Console.WriteLine("Opção inválida"); break;
                        }
                    });
        }

        private static void BridgeExemplo()
        {
            /*
             * O padrão Bridge é focado em resolver problemas em hierarquias de classes ao qual devem ser conectadas
             * onde uma é a abstração e outra a implementação
             * 
             * A "hierarquia de abstração" se refere as operações de alto nível que o usuário tem acesso, ao qual detém os
             * métodos objetivos, de "o que faz". Métodos que fazem a orquestração da chamada de outros métodos que estão na
             * "hierarquia de implementação"
             * 
             * A "hierarquia de implementação" se refere a execução concreta / implementação dos métodos de "como fazer".
             * São códigos mais detalhados. Não devemos usar o termo código de baixo-nível, pois no contexto do padrão, isso
             * não se refere de maneira 100%, tendo em vista que podem haver códigos de negócios na implementação dos métodos
             * da "hierarquia de implementação"
             * 
             * O PRINCIPAL OBJETIVO DO PADRÃO BRIDGE É SEPARAR AS HIERARQUIAS DE ABSTRAÇÃO E IMPLEMENTAÇÃO
             * ISSO PERMITE UMA MELHOR FLEXIBILIDADE E REFORÇA O "SRP", "OCP", TENDO EM VISTA QUE A CRIAÇÃO DE UM NOVO
             * 
             */

            /*
             * Dado uma situação em que precisamos trabalhar com peças de automotivas
             * Enxergamos duas hierarquias de classes, sendo "Peca" (motor, freio, assento, etc) e "Automovel" (carro, motocicleta, caminhão, etc)
             * Se precisarmos criar uma combinação dessas hierarquias geraria uma explosão de possíveis classes
             *  - Exemplo: AssentoMoto, AssentoCarro, AssentoCaminhao
             *             FreioMoto, FreioCarro, FreioCaminhao
             *             MotorMoto, MotorCarro, MotorCaminhao
             *             
             * O surgimento de uma nova peça ou veículo, geraria a necessidade de criações de novas classes de forma exponencial
             * 
             * 3 classes (hierarquia Automovel) x 3 classes (hierarquia Peca) = 9 classes
             * 4 classes (hierarquia Automovel) x 3 classes (hierarquia Peca) = 12 classes
             * ...
             * 
             */

            /*
             * Felizmente, com o padrão Bridge a necessidade de criar inúmeras classes é resolvido, 
             * fazendo a separação da Abstração e Implementação
             * 
             * Podemos levar em consideração que o Veiculo é a camada de Abstração, tendo em vista que é a hierarquia
             * de classes em que um Cliente (ou motorista/piloto/passageiro) pode executar os métodos de forma mais objetiva,
             * seja "sentar no assento (o que preenche o assento)", "ligar automóvel (o que faz o motor ser ligado)" ou
             * "freirar (o que faz com que o freio seja acionado)".
             * 
             * Já a Peca é a camada de Implementação, tendo em vista que o funcionamento de como as peças funcionam não é de 
             * importância direta do motorista/piloto/passageiro, funcionando a ação principal já estaríamos satisfeito.
             * 
             * Desta forma, poderíamos montar as seguintes classes
             * 
             * Abstração: Veiculo: Carro, Moto, Caminhao
             * Implementação: Peca: Assento, Freio, Motor
             * 
             * Vale ressaltar, que Carro, Moto e Caminhao devem ser consideradas como "Abstracao Refinada", tendo em vista
             * que o tipo de veiculo pode ter operações adicionais dependendo da funcionalidade
             * 
             * 
             * 
             */

            Automovel carro = new Automovel(5, true, 4, TipoAutomovel.CARRO);
            Automovel motocicleta = new Automovel(2, true, 1, TipoAutomovel.MOTOCICLETA);
            Automovel caminhao = new Automovel(6, true, 2, TipoAutomovel.CAMINHAO);


            IList<IPecaImplementor> pecasImplementors = new List<IPecaImplementor>()
            {
                new AssentoImplementor(),
                new MotorImplementor(),
                new FreioImplementor()
            };

            foreach(var pecaImplementor in pecasImplementors)
            {
                AutomovelAbstraction automovelAbstraction = new AutomovelAbstraction(pecaImplementor);

                automovelAbstraction.Executar(carro);
                automovelAbstraction.Executar(motocicleta);
                automovelAbstraction.Executar(caminhao);
            }

        }

    }
}
