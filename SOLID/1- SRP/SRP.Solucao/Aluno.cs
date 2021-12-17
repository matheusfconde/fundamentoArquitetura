using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Solucao
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public CPF CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar()
        {
            return Email.Validar() && CPF.Validar();
        }
    }
}
