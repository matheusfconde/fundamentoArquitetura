using SOLID.SRP.Solucao;

namespace SOLID.SRP.Solucao
{
    public class AlunoService
    {
        public string AdicionarAluno(Aluno aluno)
        {
            if (!aluno.Validar())
                return "Dados do Aluno inválidos";

            var repo = new AlunoRepository();
            repo.AdicionarAluno(aluno);

            EmailServices.Enviar("teste@teste.com", aluno.Email.Endereco, "Bem vindo", "Parabéns, seu cadastro foi efetuado com sucesso");

            return "Aluno cadastrado com sucesso";
        }
    }
}
