using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Solucao
{
    public class CPF
    {
        public string Numero { get; set; }

        public bool Validar()
        {
            return Numero.Length == 11;
        }

        public void AdicionaCPF(string cpf)
        {
            this.Numero = cpf;
        }
    }
}
