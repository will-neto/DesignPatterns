using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Builder.Exemplo1
{
    internal class CasaPedraBuilder : ICasaBuilder
    {
        private Casa _casa;

        public void Inicializar()
        {
            _casa = new Casa();
            _casa.Material = Material.Pedra;
        }

        public void Banheiros(short banheiros)
        {
            ValidaObjetoInicializado();
            Console.WriteLine($"Incluindo banheiros de {_casa.Material}");
            _casa.Banheiros = banheiros;
        }

        public void Portas(short portas)
        {
            ValidaObjetoInicializado();
            Console.WriteLine($"Incluindo portas de pedra {_casa.Material}");
            _casa.Portas = portas;
        }

        public void Quartos(short quartos)
        {
            ValidaObjetoInicializado();
            Console.WriteLine($"Incluindo quartos de pedra {_casa.Material}");
            _casa.Quartos = quartos;
        }

        public Casa Obter()
        {
            return _casa;
        }

        private void ValidaObjetoInicializado()
        {
            if (_casa == null) throw new NullReferenceException("O Builder deve ser inicializado através do método \"Inicializar()\"");
        }

    }
}
