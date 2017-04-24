using System;
using ISP.Solucao.Interfaces;

namespace ISP.Solucao
{
    public class Fusion : ICarroLuxo
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
