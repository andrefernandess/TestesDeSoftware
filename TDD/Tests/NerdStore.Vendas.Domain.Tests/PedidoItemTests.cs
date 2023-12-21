using NerdStore.Vendas.Core;

namespace NerdStore.Vendas.Domain.Tests
{
    public class PedidoItemTests
    {
        [Fact(DisplayName = "Item pedido abaixo do permitido")]
        [Trait("Categoria", "Vendas - PedidoItem")]
        public void AdicionarItemPedido_UnidadesAbaixoDoPermitido_DeveRetornarException()
        {
            // Arrange
            var produtoId = Guid.NewGuid();

            // Act && Assert
            Assert.Throws<DomainException>(() => new PedidoItem(produtoId, "Produto Teste", 0, 100));
        }
    }
}
