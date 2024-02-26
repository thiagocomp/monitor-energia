namespace MonitorEnergia.Domain
{
    public class Pulso(DateTime _datahora, Cliente _cliente)
    {
        protected DateTime DataHora { get; set; } = _datahora;
        protected Cliente Cliente { get; set; } = _cliente;
    }
}
