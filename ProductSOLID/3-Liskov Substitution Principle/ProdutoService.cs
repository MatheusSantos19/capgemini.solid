using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSOLID._3_Liskov_Substitution_Principle
{
    class ProductService
    {
        public string ObterCaracteristicaProduto(Produto produto)
        {
            return produto.ObterCaracteristica();
        }

    }
}
