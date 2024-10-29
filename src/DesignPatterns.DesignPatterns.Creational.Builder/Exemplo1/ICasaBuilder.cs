using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Builder.Exemplo1
{
    internal interface ICasaBuilder
    {
        void Inicializar();
        void Portas(short portas);
        void Quartos(short quartos);
        void Banheiros(short banheiros);

        Casa Obter();
    }
}
