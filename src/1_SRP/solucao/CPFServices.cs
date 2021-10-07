//SRP = Principio da Responsabilidade unica
namespace classes
{
    public static class CPFServices
    {
        public static bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}