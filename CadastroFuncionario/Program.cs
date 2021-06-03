using CadastroFuncionario.Funcionarios;
using System;

namespace CadastroFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CADASTRO DE FUNCIONÁRIOS =====");
            Console.WriteLine("");

            GerenciadorFuncionario gerenciador = new GerenciadorFuncionario();

            Desenvolvedor fernanda = new Desenvolvedor("Fernanda", "123456789");
            fernanda.DataNascimento = "17/03/1987";
            fernanda.Endereco = "Avenida Rio de Janeiro, 13";
            gerenciador.Cadastrar(fernanda);

            Console.WriteLine("*** Lista de Funcionario ***");
            Console.WriteLine("");
            Console.WriteLine("Nome: " + fernanda.Nome);
            Console.WriteLine("CPF: " + fernanda.Cpf);
            Console.WriteLine("Data de Nascimento: " + fernanda.DataNascimento);
            Console.WriteLine("Endereço: " + fernanda.Endereco);
            Console.WriteLine("Salario: " + fernanda.ValorReceber());
            Console.WriteLine("ID Funcionário: " + fernanda.GetIdFuncionario());

            Estagiario paula = new Estagiario("Paula", "987654321");
            paula.DataNascimento = "10/03/1980";
            paula.Endereco = "Rua Qualquer, 21";
            gerenciador.Cadastrar(paula);

            Console.WriteLine("=========================");
            Console.WriteLine("");
            Console.WriteLine("Nome: " + paula.Nome);
            Console.WriteLine("CPF: " + paula.Cpf);
            Console.WriteLine("Data de Nascimento: " + paula.DataNascimento);
            Console.WriteLine("Endereço: " + paula.Endereco);
            Console.WriteLine("Salario: " + paula.ValorReceber());
            Console.WriteLine("ID Funcionário: " + paula.GetIdFuncionario());
            Console.WriteLine("=========================");
            Console.WriteLine("");
            Console.WriteLine("TOTAL DE FUNCIONÁRIOS: " + Funcionario.TotalFuncionario);
            Console.ReadLine();
        }
    }
}
