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
    public class FreteTeste
    {
        [Fact]
        public void TestFrete()
        {

            //Arrange
            Mock<IFreteService> mock = new Mock<IFreteService>();
            mock.Setup(m => m.CalcularFrete()).Returns(7.52);

            //Act
            Frete frete = new Frete(mock.Object)
            {
                Cep = 26185010,
                Peso = 5
            };

            double resultado = frete.CalcularFrete();

            //Assert
            Assert.Equal(12.52, resultado);
        }
    }
}
