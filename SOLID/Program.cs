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
                    Console.WriteLine("Uma classe deve ter um, e apenas um, motivo para ser modificada”. (Ela faz apenas uma coisa).");
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
                    Console.WriteLine("Entidades de software (classes, módulos, funções etc.) devem estar abertas para extensão, mas fechadas para modificação.");                   
                    CaixaEletronico.Operacoes();
                    break;

                case '3':
                    Console.WriteLine("Subclasses devem ser substituíveis por Superclasses.” (Existe o por que disso ser uma afirmação correta, uma explicação que Eduardo gosta muito é a frase abaixo: Se nada como um pato, voa como um pato, porém precisa de baterias, provavelmente você possui um problema de abstração.");
                    CalculoArea.Calcular();
                    break;
                
                case '4':
                    Console.WriteLine("Muitas interfaces específicas são melhores do que uma interface única.");
                    break;

                case '5':
                    Console.WriteLine(" Dependa de uma abstração e não de uma implementação. - Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações. Abstrações não devem depender de detalhes. Detalhes devem depender de abstração.");
                    break;
            }
        }
    }
}
