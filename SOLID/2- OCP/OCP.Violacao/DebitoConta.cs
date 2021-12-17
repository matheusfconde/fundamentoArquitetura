using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar (decimal valor, string conta, TipoConta tipoConta)
        {
            if(tipoConta == TipoConta.Corrente)
            {
                //Debita Conta Corrente
                //implementação não vem ao caso, quero apenas demonstrar
                //o conhecimento em Open Closed Principle.
            }

            if (tipoConta != TipoConta.Poupanca)
            {
                //Valida Aniversário da Conta
                //Debita Conta Poupança
                //implementação não vem ao caso, quero apenas demonstrar
                //o conhecimento em Open Closed Principle.
            }
        }
    }
}
