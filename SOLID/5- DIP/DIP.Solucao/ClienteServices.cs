using SOLID.DIP.Solucao.Interfaces;

namespace SOLID.DIP.Solucao
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;


        //Injeção de dependência, é uma forma de inversão de controle. Se está apenas instanciando a interface é abstração.
        //Eu como clienteservices não sou obrigado a saber instanciar o IEmailServices e IClienteRepository, quem for consumir a ClienteServices que tem que saber.

        public ClienteServices(
            IEmailServices emailServices,
            IClienteRepository clienteRepository)
        {
            _emailServices = emailServices;
            _clienteRepository = clienteRepository;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            //Eu inverti o controle, quando eu chamo um método adicionar cliente, quem está realizando o processo de adicionar cliente, é a classe da clienteRepository.
            _clienteRepository.AdicionarCliente(cliente);

            _emailServices.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns está Cadastrado");

            return "Cliente cadastrado com sucesso";
        }
    }

    public class TesteDip
    {
        public TesteDip()
        {
            var cliService = new ClienteServices(new EmailServices(), new ClienteRepository2());
        }
    }
}
