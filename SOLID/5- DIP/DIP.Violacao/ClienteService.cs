using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.Violacao
{
    public class ClienteService // módulo de alto nível. abstração de negócios.
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            //ISSO É UMA IMPLEMENTAÇÃO, ALTO ACOPLAMENTO. A classe ClientService não é obrigada a saber como instanciar a classe ClientRepository.
            var repo = new ClienteRepository(); // módulo de baixo nível. respositorio, infra, etc.
            repo.AdicionarCliente(cliente);

            EmailServices.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }
}
