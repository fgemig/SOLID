using System;

namespace OCP.Solucao
{
    public class Hatch : Veiculo
    {
        public override decimal Valor(DateTime retirada, DateTime entrega)
        {
            var diasCorridos = (entrega - retirada).Days;
            return diasCorridos * 50.00M;
        }
    }
}
