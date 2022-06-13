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
    public class PagamentoTeste
    {
        [Fact]
		public void ValidaPagamento() {
			// Arrange
			Mock<IPagamentoService> mock = new Mock<IPagamentoService>();
			mock.Setup(m => m.ValidaPagamento()).Returns(true);

			//ACT
			Pagamento pagamento = new Pagamento(mock.Object)
			{
				Id = 1,
				NumCartao = "10146686492",
				Ano = "2025",
			};
			var resultado = pagamento.ValidaPagamento(pagamento);
			bool esperado = true;
		
			// Assert
			Assert.Equal(resultado, esperado);
		}
    }
}
