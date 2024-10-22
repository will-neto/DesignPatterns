using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactory.Exemplo1
{
    // Fabrica concreta que define a implementação da criação do produto específico da fábrica (familia + variante) = pratos + brasileira
    public class RestauranteBrasileiro : Restaurante
    {
        public override Entrada PedirEntrada()
        {
            Console.WriteLine("Entrada Brasileira");
            return new EntradaBrasileira();
        }

        public override Sobremesa PedirSobremesa()
        {
            Console.WriteLine("Sobremesa Brasileira");
            return new SobremesaBrasileira();
        }
    }
}
