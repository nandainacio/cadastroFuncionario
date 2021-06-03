using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFuncionario.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome, string cpf) : base(nome, cpf)
        {
        }
        public override double ValorReceber()
        {
            return Salario = 7000;
        }
    }
}
