using SOLID.LSP.Solucao;
using SOLID.OCP.Solucao_Extension_Methods;
using SOLID.SRP.Solucao;
using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Estudos sobre SOLID");
            Console.WriteLine("Escolha o princípio a ser demonstrado:");
            Console.WriteLine("1- SRP (Single Responsability Principle):");
            Console.WriteLine("2- OCP (Open Closed Principle):");
            Console.WriteLine("3- LSP (Liskov Substitution Principle):");
            Console.WriteLine("4- ISP (Interface Segregation Principle):");
            Console.WriteLine("5- DIP (Dependency Inversion Principle):");

            var opcao = Console.ReadKey();
            Console.WriteLine("");

            switch (opcao.KeyChar)
            {
                case '1':
                    //Entrada dos valores.
                    var cpf = new CPF { Numero = "11111111101" };
                    var email = new Email { Endereco = "matheusf.conde@gmail.com" };
                    var aluno = new Aluno
                    {
                        Matricula = 1,
                        Nome = "Matheus Filipe Condé Rocha",
                        DataCadastro = DateTime.Now,
                        CPF = cpf,
                        Email = email
                    };

                    var alunoService = new AlunoService();
                    Console.WriteLine(alunoService.AdicionarAluno(aluno));

                    break;

                case '2':
                    CaixaEletronico.Operacoes();
                    break;

                case '3':                    
                    CalculoArea.Calcular();
                    break;
            }
        }
    }
}
