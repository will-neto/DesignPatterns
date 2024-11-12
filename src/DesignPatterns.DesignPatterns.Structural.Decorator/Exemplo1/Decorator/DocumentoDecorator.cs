using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Decorator.Exemplo1.Decorator
{
    public abstract class DocumentoDecorator : IDocumento
    {
        protected IDocumento documento;

        public DocumentoDecorator(IDocumento documento)
        {
            this.documento = documento;
        }

        public virtual string Conteudo => documento.Conteudo;

        public abstract void AdicionarComponente(string componente);
    }
}
