using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Decorator.Exemplo1
{
    public class Documento : IDocumento
    {
        private List<string> componentes = new List<string>();

        public string Conteudo => string.Join("\n", componentes);

        public void AdicionarComponente(string componente)
        {
            componentes.Add(componente);
        }
    }
}
