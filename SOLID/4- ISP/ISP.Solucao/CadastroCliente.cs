using SOLID.ISP.Solucao.Interface;

namespace SOLID.ISP.Solucao
{
    public class CadastroCliente : ICadastroCliente
    {
        public void EnviarEmail()
        {
            //Enviar e-mail para o cliente.
        }

        public void SalvarBanco()
        {
            //Insert na tabela de Cliente
        }

        public void ValidarDados()
        {
            //Validar CPF, Email.
        }
    }
}
