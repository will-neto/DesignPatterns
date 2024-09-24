using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.FactoryMethod.Exemplo1
{
    // Produto
    // Abstração dos objetos que serão instanciados pelas subclasses da Fabrica
    public abstract class Empregado
    {
        public TipoEmpregado Tipo { get; set; }
        public abstract void FazerTrabalho();
    }

    public enum TipoEmpregado
    {
        RESIDENCIAL,
        INDUSTRIAL
    }
}
