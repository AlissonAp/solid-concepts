﻿using interfaces;

//ISP = Princípio da Segregação de Interface
namespace classes.isp
{
    public class CadastroUsuario : ICadastro
    {
        public void ValidarDados()
        {
            // Validar CPF, Email
        }

        public void Salvar()
        {
            // Insert na tabela Usuario
        }

        public void EnviarEmail()
        {
            // Enviar e-mail para o usuario
        }
    }
}