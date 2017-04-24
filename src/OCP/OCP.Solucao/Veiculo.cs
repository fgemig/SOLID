using System;

namespace OCP.Solucao
{
    public abstract class Veiculo
    {
        public abstract decimal Valor(DateTime retirada, DateTime entrega);        
    }
}
