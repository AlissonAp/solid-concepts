//OCP = Princípio Aberto/Fechado
namespace classes
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debita Conta Corrente
            return FormatarTransacao();
        }
    }
}