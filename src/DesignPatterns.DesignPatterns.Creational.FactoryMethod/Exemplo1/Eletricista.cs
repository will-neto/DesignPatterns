using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.FactoryMethod.Exemplo1
{
    // Implementação de um Produto
    public class Eletricista : Empregado
    {
        public Eletricista(TipoEmpregado tipo)
        {
            Tipo = tipo;
        }

        public override void FazerTrabalho()
        {
            if (Tipo == TipoEmpregado.RESIDENCIAL)
                Console.WriteLine("Verificando por falhas elétricas na casa...");

            if (Tipo == TipoEmpregado.INDUSTRIAL)
                Console.WriteLine("Procurando por falhas elétricas nos postes...");
        }
    }

}
