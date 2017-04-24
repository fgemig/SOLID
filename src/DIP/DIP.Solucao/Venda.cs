using System;
using System.Collections.Generic;

namespace DIP.Solucao
{
    public class Venda
    {
        public Venda(Cliente cliente)
        {
            Id = Guid.NewGuid();
            Cliente = cliente;
        }

        public Guid Id { get; private set; }

        public Cliente Cliente { get; private set; }

        public ICollection<Produto> Produtos { get; private set; }

    }
}
