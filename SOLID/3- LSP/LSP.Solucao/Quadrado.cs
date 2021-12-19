using System;

namespace SOLID.LSP.Solucao
{
    public class Quadrado : Paralelogramo
    {
        //A palavra-chave base é usada para acessar membros de classe base de dentro de uma classe derivada:
        //Chamar um método que foi substituído por outro método na classe base.
        //Especificar qual construtor de classe base deve ser chamado ao criar instâncias da classe derivada.
        //Um acesso de classe base é permitido somente em um construtor, em um método de instância ou em um acessador de propriedade de instância.
        //É um erro usar a palavra-chave base de dentro de um método estático.
        //A classe base que é acessada é a que é especificada na declaração de classe. Por exemplo, se você especificar class ClassB : ClassA, os membros da ClassA são acessados da ClassB, independentemente da classe base da ClassA.
        //https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/base
        public Quadrado(int altura, int largura)
            : base(altura, largura)
        {
            if (largura != altura)
                throw new ArgumentException("Os dois lados do quadrado precisam ser iguais");
        }
    }
}
