using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactory.Exemplo1
{
    // Fabrica concreta que define a implementação da criação do produto específico da fábrica (familia + variante) = pratos + chinesa
    public class RestauranteChines : Restaurante
    {
        public override Entrada PedirEntrada()
        {
            Console.WriteLine("Entrada Chinesa");
            return new EntradaChinesa();
        }

        public override Sobremesa PedirSobremesa()
        {
            Console.WriteLine("Sobremesa Chinesa");
            return new SobremesaChinesa();
        }
    }
}
