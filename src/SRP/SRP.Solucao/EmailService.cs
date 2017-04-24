﻿using System.Net.Mail;

namespace SRP.Solucao
{
    public class EmailService
    {
        public void EnviarEmailConfirmacao(string para, string assunto, string mensagem)
        {

            var email = new MailMessage("contato@empresa.com", para);

            var client = new SmtpClient
            {
                Port = 465,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.gmail.com"
            };

            email.Subject = assunto;
            email.Body = mensagem;

            client.Send(email);

        }
    }
}
