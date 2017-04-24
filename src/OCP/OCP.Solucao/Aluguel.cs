using System;

namespace OCP.Solucao
{
    public class Aluguel
    {
        public Aluguel()
        {
            var carro1 = new Hatch();
            Console.WriteLine(carro1.Valor(DateTime.Now, DateTime.Now.AddDays(3)));

            var carro2 = new Sedan();
            Console.WriteLine(carro2.Valor(DateTime.Now, DateTime.Now.AddDays(1)));

            var carro3 = new SUV();
            Console.WriteLine(carro3.Valor(DateTime.Now, DateTime.Now.AddDays(5)));
        }
    }
}
