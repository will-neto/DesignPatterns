using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObjectRelationships.Dependencia
{
    internal static class Universidade
    {
        public static string Nome = "Universidade 30 de Fevereiro";

        public static UniversidadeStatus Status = UniversidadeStatus.Aberta;

        public static void AlterarStatus(UniversidadeStatus status)
        {
            Status = status;
        }

    }

    internal enum UniversidadeStatus
    {
        Aberta = 0,
        Fechada = 1,
    }
}
