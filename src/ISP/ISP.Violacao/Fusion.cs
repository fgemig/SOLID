using System;
using ISP.Violacao.Interfaces;

namespace ISP.Violacao
{
    public class Fusion : ICarro
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerou...");
        }

        public void ModoEsportivo()
        {
            Console.WriteLine("Selecionou Modo Esportivo...");
        }

        public void PilotoAutomatico()
        {
            Console.WriteLine("Ligou o piloto automático...");
        }

    }
}
