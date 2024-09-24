using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.FactoryMethod.Exemplo1
{
    // Classe abstrata da Fabrica
    // Responsável por definir o método que será utilizado para criação dos Produtos
    // Podem existir mais de um método, mas evitar múltiplos sem necessidade
    public abstract class PrestadoraServico
    {
        public abstract Empregado SolicitarEmpregado();
    }
}
