using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            //Produto não tem e-mail, o que fazer? implementação desnecessária, devido ao utilizar
            //a interface ICadastro.
            throw new NotImplementedException("Esse método não serve para nada");
        }

        public void SalvarBanco()
        {
            //Insert tabela Produto
        }

        public void ValidarDados()
        {
            //Validar valor.
        }
    }
}
