using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Violacao
{
    public class Aluguel
    {

        private decimal Valor = 50.00M;
        private int totalDias = 0;

        public Aluguel(Veiculo veiculo, int totalDias)
        {

            if (veiculo.Tipo is Tipo.Hatch)
            {
                Valor = Valor * 0.3M;
            }
            else if (veiculo.Tipo is Tipo.Sedan)
            {
                Valor = Valor * 0.5M;
            }
            else if (veiculo.Tipo is Tipo.SUV)
            {
                Valor = Valor * 0.8M;
            }

            this.totalDias = totalDias;

        }

        public decimal ValorAluguel()
        {
            return this.Valor * totalDias;
        }

    }
}
