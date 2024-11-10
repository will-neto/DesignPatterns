using DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Implementors
{
    public class MotorImplementor : IPecaImplementor
    {
        public void Executar(Automovel automovel)
        {
            Console.WriteLine($"Ligando [{automovel.TipoAutomovel}] com o motor de " +
                $"{(automovel.TipoAutomovel == TipoAutomovel.MOTOCICLETA ? "4 cilindros" : "12 cilindros")}");
        }
    }
}
