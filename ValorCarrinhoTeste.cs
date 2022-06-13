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
    public class ValorCarrinhoTeste
    {
        [Fact]
        public void CalculaValorCarrinho()
        {
            // Arrange

            //cliente
            int id = 5;
            Cliente cliente = new Cliente(id, "Lucas Perreira", "26185010", "182014705441");
            Mock<IClienteService> mockClienteService = new Mock<IClienteService>();
            mockClienteService.Setup(m => m.GetById(id)).Returns(cliente);

            //frete
            Mock<IFreteService> mockF = new Mock<IFreteService>();
            mockF.Setup(m => m.CalcularFrete()).Returns(7.00);
            Frete frete = new Frete(mockF.Object)
            {
                Cep = 26185010,
                Peso = 5
            };

            //carrinho
            Mock<ICarrinhoService> mockCar = new Mock<ICarrinhoService>();
            mockCar.Setup(m => m.ValidaCarrinho()).Returns(true);
            Carrinho carrinho = new Carrinho(mockCar.Object)
            {
                id = 1,
                data = "20/10/2022",
                ValorTotal = 22.30,
                frete = 12.00,
				idCli = 5
            };

            // ACT
            Pedido pedido = new Pedido(1, 1, cliente, frete, 22.30, carrinho);

            double resultado = pedido.CalculaValor();
            double esperado = 34.30;

            // Assert
            Assert.Equal(resultado, esperado);
        }
    }
}
