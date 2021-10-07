//ISP = Princípio da Segregação de Interface
namespace interfaces.isp
{
    public interface ICadastroUsuario : ICadastro
    {
        void EnviarEmail();
    }
}