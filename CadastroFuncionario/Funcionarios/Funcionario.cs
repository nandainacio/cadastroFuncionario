using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroFuncionario.Funcionarios
{
    public abstract class Funcionario
    {

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string Endereco { get; set; }
        public double Salario { get; set; }
        public static int TotalFuncionario { get; set; }
        public int NumFuncionario { get; set; }
        private string Id { get; set; }

        public Funcionario(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
            //GetFuncionario();
        }

        public Funcionario()
        {
            Salario = Salario;
        }
        public abstract double ValorReceber();

        public int GetFuncionario()
        {
            return TotalFuncionario++;
        }

        public string GetIdFuncionario()
        {
            string cod = "202106";
            Id = cod + TotalFuncionario;
            return Id;
        }
    }
}
