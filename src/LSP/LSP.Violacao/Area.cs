using System;

namespace LSP.Violacao
{
    public class Area
    {
        public Area()
        {

            var retangulo = new Retangulo(2, 4);
            Console.WriteLine(retangulo.Area());

            var quadrado = new Quadrado(2, 4);
            Console.WriteLine(quadrado.Area());

        }
    }
}
