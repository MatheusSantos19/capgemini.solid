using System;
using System.Collections.Generic;
using System.Text;

namespace ProductSOLID._2_Open_Closed
{
    public class Product
    {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
            private const decimal DESCONTO_PADRAO = .3M;
        

            public virtual void AplicarDesconto()
            {
                this.Preco = this.Preco * DESCONTO_PADRAO;
            }
            public Product(string nomeProduto, decimal precoProduto)
            {
            this.Nome = nomeProduto;
                this.Preco = precoProduto;
            }

        }
    }
