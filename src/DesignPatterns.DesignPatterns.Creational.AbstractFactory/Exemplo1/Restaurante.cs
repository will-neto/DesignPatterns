using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AbstractFactory.Exemplo1
{
    // Fabrica abstrata com o conjunto de métodos para criação de produtos da mesma familia (Pratos)
    public abstract class Restaurante
    {
        public abstract Entrada PedirEntrada();
        public abstract Sobremesa PedirSobremesa();
    }
}
