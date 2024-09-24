using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.Prototype.Exemplo3
{
    public class RegistroEstilos
    {
        private IDictionary<Guid, EstiloPrototipo> _estilos = new Dictionary<Guid, EstiloPrototipo>();

        public RegistroEstilos() { }

        public void Registrar(EstiloPrototipo estilo)
        {
            _estilos.Add(estilo.Id, estilo);
        }

        public EstiloPrototipo Resgatar(Guid id)
        {
            if (_estilos[id] != null)
            {
                return _estilos[id].Clone();
            }

            throw new ArgumentNullException("Não foi possível encontrar o estilo procurado!");
        }


    }
}
