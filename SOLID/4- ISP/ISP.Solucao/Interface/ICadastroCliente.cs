
namespace SOLID.ISP.Solucao.Interface
{
    public interface ICadastroCliente : ICadastro
    {
        void ValidarDados();
        void EnviarEmail();
    }
}
