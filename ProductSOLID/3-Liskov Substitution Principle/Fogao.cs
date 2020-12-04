using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSOLID._3_Liskov_Substitution_Principle
{
    public class Fogao : Produto
    {
        public Fogao(string nomeProduto, decimal precoProduto) : base(nomeProduto, precoProduto)
        {
        }
        public override string ObterCaracteristica()
        {
            return "Fogao 4 bocas";
        }
    }
}
