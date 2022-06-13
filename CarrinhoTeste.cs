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
    public class CarrinhoTeste
    {

        [Fact]
        public void TesteAdicionarAoCarrinho()
        {

            //Arrange
            
            Carrinho carrinho = new Carrinho(4, 10.70, "10/10/2022", 21.30, 5);
            Produto produto = new Produto(2, "arroz", 2, 12.30, "Fornecedor1");

            Mock<IItensCarrinhoService> mock = new Mock<IItensCarrinhoService>();
            mock.Setup(m => m.GetItensCarrinhos(1)).Returns(true);

            //Act
            ItensCarrinho itens = new ItensCarrinho(mock.Object)
            {
                Id = 1,
                IdCarrinho = 4,
                IdProduto = 2,
                ValorUnitario = 20.30,
                Quantidade = 2
            };

            //Act
            
            bool resultado = itens.ValidaIdCarProd(4, 2);
            bool esperado = true;

            //Assert
            Assert.Equal(esperado, resultado);
        }
    }
}
