using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.FactoryMethod.Exemplo1
{
    // Fabrica para Encanador
    public class PrestadoraDeAgua : PrestadoraServico
    {
        public TipoCliente TipoCliente { get; private set; }

        public PrestadoraDeAgua(TipoCliente tipoCliente)
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
                ? new Encanador(TipoEmpregado.RESIDENCIAL)
                : new Encanador(TipoEmpregado.INDUSTRIAL);
        }
    }
}
