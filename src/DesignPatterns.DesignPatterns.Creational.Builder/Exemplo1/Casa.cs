using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Builder.Exemplo1
{
    internal class Casa
    {
        public short Portas { get; set; }
        public short Quartos { get; set; }
        public short Banheiros { get; set; }
        public Material Material {get; set;}

        public override string? ToString()
        {
            return $"Construída uma bela casa de {this.Material} com {this.Portas} porta(s), {this.Quartos} quarto(s) e {this.Banheiros} banheiro(s)";
        }
    }
}
