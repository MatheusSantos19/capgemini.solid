using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSOLID._3_Liskov_Substitution_Principle
{
    public abstract class Product
    {
        public string Nome { get; set; }
        public Decimal Preco { get; set; }
        public abstract string ObterCaracteristica();

        public Product(string nomeProduto, decimal precoProduto)
        {
            this.Nome = nomeProduto;
            this.Preco = precoProduto;
        }

        public string ObterCaracteristicaProduto(Product produto)
        {
            return produto.ObterCaracteristica();
        }
    }

}
}
