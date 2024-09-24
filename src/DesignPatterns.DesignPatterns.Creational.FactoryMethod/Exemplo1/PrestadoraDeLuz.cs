using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.FactoryMethod.Exemplo1
{
    // Fabrica para Eletricista
    public class PrestadoraDeLuz : PrestadoraServico
    {
        public TipoCliente TipoCliente { get; private set; } 

        public PrestadoraDeLuz(TipoCliente tipoCliente)
        {
            TipoCliente = tipoCliente;    
        }

        // Método de Fábrica
        public override Empregado SolicitarEmpregado()
        {
            // Podem haver algumas regras para criação do objeto
            // Isso nao fere o SRP (Principio de Segregação de Responsabilidade), tendo em vista que a responsabilidade
            //  do Método de Fábrica é disponibilizar um Produto correto
            return TipoCliente == TipoCliente.RESIDENCIA 
                ? new Eletricista(TipoEmpregado.RESIDENCIAL)
                : new Eletricista(TipoEmpregado.INDUSTRIAL);
        }
    }
}
