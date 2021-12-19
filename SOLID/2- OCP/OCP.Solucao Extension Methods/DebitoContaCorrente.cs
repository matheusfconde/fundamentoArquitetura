namespace SOLID.OCP.Solucao_Extension_Methods
{
    //Extensions Methodos: Quando você cria um método no caso DebitarContaCorrente, mas, ela se comporta como se fosse uma classe da this DebitoConta.
    //Para criar um extensions methods: Primeiro a classe precisa ser static e o método também, pois na hora
    //de compilar, o compilador vai entender que essa classe não tem um estado, e ela irá trabalhar dentro da classe DebitarContaCorrente,
    //quando se tem o this no parâmetro, estou dizendo que esse método vai ser criado/interpretado, dentro da classe DebitoConta.
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta) 
        {
            //Lógica de negócio para débito em conta corrente.
            //implementação não vem ao caso, quero apenas demonstrar
            //o conhecimento em Open Closed Principle.
            return debitoConta.FormatarTransacao();
        }
    }
}
