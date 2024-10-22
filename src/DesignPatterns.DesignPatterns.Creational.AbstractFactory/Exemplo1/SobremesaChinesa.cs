using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactory.Exemplo1
{
    // Produto concreto da familia de pratos (sobremesa) e caracteristica da comida (chinesa)
    public class SobremesaChinesa : Sobremesa
    {
        public override void Solicitar()
        {
            Console.WriteLine("Mooncake");
        }
    }
}
