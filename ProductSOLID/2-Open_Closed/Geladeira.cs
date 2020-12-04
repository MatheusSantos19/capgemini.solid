

namespace ProductSOLID._2_Open_Closed
{
    public class Geladeira : Produto
    {
        public Geladeira(string nomeProduto, decimal precoProduto) : base(nomeProduto, precoProduto)
        {
        }
        public override void AplicarDesconto()
        {
            this.Preco = this.Preco * .8m;
        }
    }
}

