using System;
using ISP.Violacao.Interfaces;

namespace ISP.Violacao
{
    public class Classic : ICarro
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerou...");
        }

        public void ModoEsportivo()
        {
            throw new NotImplementedException();
        }

        public void PilotoAutomatico()
        {
            throw new NotImplementedException();
        }
    }
}
