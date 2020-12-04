using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSOLID._3_Liskov_Substitution_Principle
{
    public class Geladeira : Produto
    {
        public Geladeira(string nomeProduto, decimal precoProduto) : base(nomeProduto, precoProduto)
        {
        }
        public override string ObterCaracteristica()
        {
            return "Geladeira Frost Free";
        }
    }

}
