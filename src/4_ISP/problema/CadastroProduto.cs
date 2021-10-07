using System;
using interfaces;

//ISP = Principio da Segregacaoo de Interface
namespace classes
{
    public class CadastroProduto : ICadastro
    {
        public void ValidarDados()
        {
            // Validar valor
        }

        public void Salvar()
        {
            // Insert tabela Produto
        }

        public void EnviarEmail()
        {
            // Produto n�o tem e-mail
            // Qual dever� ser a implementa��o?
        }
    }
}