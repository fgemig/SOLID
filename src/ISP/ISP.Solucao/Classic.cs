using System;
using ISP.Solucao.Interfaces;

namespace ISP.Solucao
{
    public class Classic : ICarroPopular
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerou...");
        }

        public void Parar()
        {
            Console.WriteLine("Parou...");
        }
    }
}
