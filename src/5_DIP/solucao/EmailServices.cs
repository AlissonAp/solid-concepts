using System.Net.Mail;
using interfaces.dip.solucao;

//DIP = Principio da Inversao de Dependencia
namespace classes.dip.solucao
{
    public class EmailServices : IEmailServices
    {
        public bool IsValid(string email)
        {
            return email.Contains("@");
        }

        public void Enviar(string de, string para, string assunto, string mensagem)
        {
            var mail = new MailMessage(de, para);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = assunto;
            mail.Body = mensagem;
            client.Send(mail);
        }
    }
}