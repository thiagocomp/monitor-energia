using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MonitorEnergia.Domain
{
    public class Cliente (string _nomeCliente, Distribuidora distribuidora)
    {

        protected BigInteger ClienteId { get; set; }
        protected string NomeCliente { get; set; } = _nomeCliente;
        protected Distribuidora Distribuidora { get; set; } = distribuidora;
    }
}
