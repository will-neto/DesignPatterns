using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Prototype.Exemplo2
{
    // Utilizando interface ICloneable
    // Ela contem um método "Clone()" para definição da lógica de clonagem
    // É utilizada em algumas classes nativas do .NET, mas não deixa de ter a mesma necessidade de implementação da lógica de clonagem pela classe concreta
    public class Banana : ICloneable
    {
        public string Tipo { get; set; }
        public Banana()
        {
                    
        }

        public Banana(string tipo)
        {
            Tipo = tipo;
        }

        public Banana(Banana banana)
        {
            Tipo = banana.Tipo;
        }

        public object Clone()
        {
            return new Banana(this);
        }

        public void Bananaaaaas()
        {
            var bananas = new Random().Next(1, 300);

            for (int i = 0; i < bananas; i++)
            {
                Banana clonedBanana = (Banana) this.Clone();
                Console.WriteLine($"Bananaaaa {clonedBanana.Tipo} !!!!!!!!!!! {clonedBanana.GetHashCode()} ");
            }
        }
    }
}
