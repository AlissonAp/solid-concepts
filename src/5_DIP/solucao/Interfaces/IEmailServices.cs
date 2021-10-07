//DIP = Principio da Inversao de Dependencia
namespace interfaces.dip.solucao
{
    public interface IEmailServices
    {
        bool IsValid(string email);
        void Enviar(string de, string para, string assunto, string mensagem);
    }
}