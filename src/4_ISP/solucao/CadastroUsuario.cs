﻿using interfaces.isp;

//ISP = Princípio da Segregação de Interface
namespace classes
{
    public class CadastroUsuario : ICadastroUsuario
    {
        public void ValidarDados()
        {
            // Validar CPF, Email
        }

        public void Salvar()
        {
            // Insert na tabela Usuário
        }

        public void EnviarEmail()
        {
            // Enviar e-mail para o usuário
        }
    }
}