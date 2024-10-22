using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactory.Exemplo1
{
    // Produto concreto da familia de pratos (entrada) e caracteristica da comida (brasileira)
    public class EntradaBrasileira : Entrada
    {
        public override void Solicitar()
        {
            Console.WriteLine("Picanha com arroz e batata frita | Cerveja");
        }
    }
}
