using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSOLID._2_Open_Closed
{
    public class Fogao : Produto
    {
        public Fogao(string nomeProduto, decimal precoProduto) : base(nomeProduto, precoProduto)
        {
        }
        public override void AplicarDesconto()
        {
            this.Preco = this.Preco * .75m;
        }
    }
}
