using DIP.Solucao.Interfaces;

namespace DIP.Solucao.Services
{
    public class VendaService : IVendaService
    {

        private readonly IEmailService _emailService;
      
        public VendaService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void Adicionar(Venda venda)
        {
            // Cadastra a venda

            _emailService.EnviarEmailConfirmacao(venda.Cliente.Email, "Pedido Concluído!", "Após a confirmação do pagamento, seu pedido será despachado em até 2 dias úteis!");

        }
        
    }
}
