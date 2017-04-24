namespace DIP.Solucao.Interfaces
{
    public interface IEmailService
    {
        void EnviarEmailConfirmacao(string para, string assunto, string mensagem);
    }
}
