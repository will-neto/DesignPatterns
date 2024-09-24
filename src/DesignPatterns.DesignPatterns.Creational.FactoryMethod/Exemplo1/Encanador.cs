using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.FactoryMethod.Exemplo1
{
    // Implementação de um Produto
    public class Encanador : Empregado
    {

        public Encanador(TipoEmpregado tipo)
        {
            Tipo = tipo;
        }

        public override void FazerTrabalho()
        {
            if (Tipo == TipoEmpregado.RESIDENCIAL)
                Console.WriteLine("Verificando por vazamentos na casa...");

            if (Tipo == TipoEmpregado.INDUSTRIAL)
                Console.WriteLine("Procurando por vazamentos no prédio...");
        }
    }

}
