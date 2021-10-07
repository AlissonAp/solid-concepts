//OCP = Princípio Aberto/Fechado
namespace classes
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            // Logica de negócio para debito em conta investimento.
            return debitoConta.FormatarTransacao();
        }
    }
}