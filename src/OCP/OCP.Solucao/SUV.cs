using System;

namespace OCP.Solucao
{
    public class SUV : Veiculo
    {
        public override decimal Valor(DateTime retirada, DateTime entrega)
        {
            var diasCorridos = (entrega - retirada).Days;
            return diasCorridos * 80.00M;
        }
    }
}
