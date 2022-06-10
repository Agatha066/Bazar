using AppCrud01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Domain.Entities
{
    public class Carrinho
    {
        public int id { get; set; }
		public string data { get; set; }
        public double ValorTotal { get; set; }
		public double frete { get; set; }
        public int idCli { get; set; }
		private ICarrinhoService carrinhoService;
      
        private ICarrinhoService @object;

        public Carrinho(int id, ICarrinhoService _carrinhoService)
        {
            carrinhoService = _carrinhoService;
        }

        public Carrinho(int id, string data, double valor, double frete, int idCli)
        {
            this.id = id;
            this.data = data;
            this.ValorTotal = valor;
            this.frete = frete;
			this.idCli = idCli;
        }

        public Carrinho(ICarrinhoService @object)
        {
            this.@object = @object;
        }

        public bool ValidaCarrinho(ICarrinhoService carrinho){
			return true;
		}
		
    }
}
