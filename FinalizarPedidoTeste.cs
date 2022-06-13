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
    public class FinalizarPedidoTeste
    {
        [Fact]
		public void FinalizaPedido() {
			// Arrange
			int id = 1;
            Cliente cliente = new Cliente(id, "Lucas Perreira", "26185010","182014705441"); 
			Carrinho carrinho = new Carrinho(id, "20/10/2022", 17.99, 12.0); 
			
			Mock<IPedidoService> mock = new Mock<IPedidoService>();
			mock.Setup(m => m.ValidaCliente()).Returns(true);

			//ACT
			Pedido pedido = new Pedido(1, 1, cliente, null, 22.30, carrinho);
			var resultado1 = pedido.ValidaCarrinho(carrinho);
			var resultado2 = pedido.ValidaCliente(cliente);
			
			bool esperado = true;
		
			// Assert
			Assert.Equal(esperado, resultado1);
			Assert.Equal(esperado, resultado2);
		}
    }
}
