namespace SOLID.OCP.Solucao_Extension_Methods
{
    //Extensions Methodos: Quando você cria um método no caso DebitarContaPoupanca, mas, ela se comporta como se fosse uma classe da this DebitoConta.
    //Para criar um extensions methods: Primeiro a classe precisa ser static e o método também, pois na hora
    //de compilar, o compilador vai entender que essa classe não tem um estado, e ela irá trabalhar dentro da classe DebitarContaPoupanca,
    //quando se tem o this no parâmetro, estou dizendo que esse método vai ser criado/interpretado, dentro da classe DebitoConta.
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            //Lógica de negócio para débito em conta poupanca.
            //implementação não vem ao caso, quero apenas demonstrar
            //o conhecimento em Open Closed Principle.
            return debitoConta.FormatarTransacao();
        }
        
    }
}
