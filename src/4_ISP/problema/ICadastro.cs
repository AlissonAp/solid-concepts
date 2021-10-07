//ISP = Princípio da Segregação de Interface
namespace interfaces
{
    public interface ICadastro
    {
        void ValidarDados();
        void Salvar();
        void EnviarEmail();
    }
}