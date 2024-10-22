using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactory.Exemplo1
{
    // Produto abstrato
    // Terá familia de pratos com suas variantes dependendo do restaurante
    public abstract class Entrada
    {
        public abstract void Solicitar();
    }
}
