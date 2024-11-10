using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Bridge.Exemplo1.Domain
{
    public class Automovel
    {
        public Automovel(int assentos, bool freioABS, int passageiros, TipoAutomovel tipoAutomovel)
        {
            Assentos = assentos;
            FreioABS = freioABS;
            Passageiros = passageiros;
            TipoAutomovel = tipoAutomovel;
        }

        public int Assentos { get; set; }
        public bool FreioABS { get; set; }
        public int Passageiros { get; set; }
        public TipoAutomovel TipoAutomovel { get; set;}
    }

    public enum TipoAutomovel
    {
        CARRO,
        MOTOCICLETA,
        CAMINHAO
    }
}
