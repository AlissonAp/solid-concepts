using interfaces.dip.solucao;

//DIP = Principio da Inversao de Dependencia
namespace classes.dip.solucao
{
    public class CPFServices : ICPFServices
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}