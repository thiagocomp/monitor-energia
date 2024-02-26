using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MonitorEnergia.Domain
{
    public class Distribuidora (string _nomeDistribuidora)
    {
        protected BigInteger DistribuidoraId { get; set; }
        protected string NomeDistribuidora { get; set; } = _nomeDistribuidora;
        protected TimeOnly InicioHorarioPonta { get; set; }
        protected TimeOnly FimHorarioPonta { get; set; }
        protected TimeOnly InicioHorarioIntermediario1 { get; set; }
        protected TimeOnly FimHorarioIntermediario1 { get; set; }
        protected TimeOnly? InicioHorarioIntermediario2 { get; set; }
        protected TimeOnly? FimHorarioIntermediario2 { get; set; }
    }
}
