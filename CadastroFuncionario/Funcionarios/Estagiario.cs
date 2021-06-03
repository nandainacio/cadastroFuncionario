using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFuncionario.Funcionarios
{
    public class Estagiario : Funcionario
    {
        public Estagiario(string nome, string cpf) : base(nome, cpf)
        {
        }
        public override double ValorReceber()
        {
            return Salario = 2500;
        }
    }
}
