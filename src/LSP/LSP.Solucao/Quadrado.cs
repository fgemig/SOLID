using System;

namespace LSP.Solucao
{
    public class Quadrado : Retangulo
    {
        public Quadrado(double altura, double largura) 
            : base(altura, largura)
        {
            if (!IsValid())
                throw new ArgumentException("Um quadrado precisa ter ambos os lados iguais.");
        }

        public bool IsValid() => Altura == Largura;
    }
}
