//DIP = Principio da Inversao de Dependencia
namespace classes.dip
{
    public static class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}