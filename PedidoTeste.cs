using AppCrud01.Domain.Entities;
using AppCrud01.Domain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppCrud01.Teste
{
    public class PedidoTeste
    {
        [Fact]
		public void ValidarCarrinho() {
			// Arrange
			int id = 1;
			Cliente cliente = new Cliente(id, "Lucas Perreira", "26185010", "182014705441");
			Mock<ICarrinhoService> mockCar = new Mock<ICarrinhoService>();
            mockCar.Setup(m => m.ValidaCarrinho()).Returns(true);
			Carrinho carrinho = new Carrinho(mockCar.Object)
			{
				id = 1,
				data = "20/10/2022",
				ValorTotal = 22.30,
				frete = 12.00
			};

			// ACT
			Pedido pedido = new Pedido(1, 1, cliente, null, 22.30, carrinho);
	
			var resultado = pedido.ValidaCarrinho(carrinho);
			bool esperado = true;

			// Assert
			Assert.Equal(resultado, esperado);
		}
    }
}
