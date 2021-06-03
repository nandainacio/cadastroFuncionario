using CadastroFuncionario.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFuncionario
{
    public class GerenciadorFuncionario
    {
        public GerenciadorFuncionario()
        {
        }
        public int TotalFuncionario { get; private set; }
        public string Id { get; private set; }

        public void Cadastrar(Funcionario funcionario)
        {
            TotalFuncionario += funcionario.GetFuncionario();
        }

    }
}
