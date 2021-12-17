using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1__SRP.SRP.Violacao
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarAluno()
        {
            if (!Email.Contains("@"))
                return "Aluno com e-mail inválido";

            if (CPF.Length != 11)
                return "Aluno com CPF inválido";

            //indo ao banco de dados realizar conexão e inclusão do aluno.

            return "Aluno cadastrado com sucesso";
        }
    }
}
