using classes.dip;

//DIP = Principio da Inversao de Dependencia
namespace interfaces.dip.solucao
{
    public interface IUsuarioRepository
    {
        void AdicionarUsuario(Usuario usuario);
    }
}