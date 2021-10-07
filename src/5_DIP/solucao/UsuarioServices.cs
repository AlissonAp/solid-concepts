
using interfaces.dip.solucao;

//DIP = Princípio da Inversão de Dependência
namespace classes.dip.solucao
{
    public class UsuarioServices : IUsuarioServices 
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IEmailServices _emailServices;

        public UsuarioServices(
            IEmailServices emailServices, 
            IUsuarioRepository usuarioRepository)
        {
            _emailServices = emailServices;
            _usuarioRepository = usuarioRepository;
        }

        public string AdicionarUsuario(Usuario usuario)
        {
            if (!usuario.IsValid())
                return "Dados inválidos";

            _usuarioRepository.AdicionarUsuario(usuario);

            _emailServices.Enviar("csharp@solid.com", usuario.Email, "Bem Vindo", "Parabéns está Cadastrado");

            return "Usuário cadastrado com sucesso";
        }
    }
}