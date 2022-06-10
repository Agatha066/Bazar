using AppCrud01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Domain.Entities
{
    public class Pagamento
    {
		public int Id { get; set; }
        public string NumCartao { get; set; }
        public string Ano  { get; set; }

        private IPagamentoService pagamentoService;

        public Pagamento(IPagamentoService _pagamentoService)
        {
            pagamentoService = _pagamentoService;
        }

        public object ValidaPagamento(Pagamento pagamento)
        {
            return true;
        }
    }
}
