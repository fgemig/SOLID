using System;

namespace OCP.Solucao
{
    public class Sedan : Veiculo
    {
        public override decimal Valor(DateTime retirada, DateTime entrega)
        {
            var diasCorridos = (entrega - retirada).Days;
            return diasCorridos * 60.00M;
        }
    }
}
