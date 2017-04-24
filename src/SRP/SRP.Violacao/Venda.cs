using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace SRP.Violacao
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

        public void Concluir()
        {

            var email = new MailMessage("contato@empresa.com", Cliente.Email);

            var client = new SmtpClient
            {
                Port = 465,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.gmail.com"
            };

            email.Subject = "Pedido Concluído!";
            email.Body = "Após a confirmação do pagamento, seu pedido será despachado em até 2 dias úteis!";

            client.Send(email);

        }

    }
}
