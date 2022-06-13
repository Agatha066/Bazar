using AppCrud01.Application.AppService;
using AppCrud01.Application.ViewModel;
using AppCrud01.Domain.Entities;
using AppCrud01.Domain.Interfaces;
using Moq;
using System;
using Xunit;

namespace AppCrud01.Teste
{
    public class ClienteTeste
    {
        [Fact]
        public void TesteValidacaoCliente()
        {
            // Arrange
            int id = 1;
            Cliente cliente = new Cliente(1, "Lucas Perreira", "26185010","182014705441"); 
            Mock<IClienteService> mockClienteService = new Mock<IClienteService>();
            mockClienteService.Setup(m => m.GetById(1)).Returns(cliente);

            // Act
            ClienteAppService clienteAppService = new ClienteAppService(mockClienteService.Object);
            ClienteResultViewModel clienteEsperado = clienteAppService.GetCliente(id);

            //Assert
            //pegando cpf
            Assert.Equal("182014705441", clienteEsperado.GetCpf());
        }
    }
}
