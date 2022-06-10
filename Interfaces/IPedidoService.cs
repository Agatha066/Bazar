using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Domain.Interfaces
{
    public interface IPedidoService
    {
        public bool ValidaPagamento (IPagamentoService pagamento);
		public bool ValidaCarrinho (ICarrinhoService carrinho);
        public bool ValidaCliente();
		public bool CalculaValor();
    }
}
