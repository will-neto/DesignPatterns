using DesignPatterns.DesignPatterns.Creational.Builder.Exemplo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Builder.Exemplo2
{
    internal class CasaDirector
    {
        private ICasaBuilder _builder;

        public CasaDirector(ICasaBuilder builder)
        {
            MudarConstrutor(builder);
        }

        public void ConstruirCasaFamilia()
        {
            _builder.Inicializar();
            _builder.Quartos(3);
            _builder.Banheiros(2);
            _builder.Portas(7);
        }

        public void ConstruirCasaSolteiro()
        {
            _builder.Inicializar();
            _builder.Quartos(1);
            _builder.Banheiros(1);
            _builder.Portas(3);
        }

        public void MudarConstrutor(ICasaBuilder builder)
        {
            _builder = builder;
        }

        public Casa Obter()
        {
            return _builder.Obter();
        }

    }
}
