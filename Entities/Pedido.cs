using AppCrud01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Domain.Entities
{
    public class Pedido {
        
        public Cliente cliente;
        public Frete frete;
        public Carrinho carrinho;

        public int id { get; set; }
		public int idCliente { get; set; }
		public double valorTotal { get; set; }
		public IClienteService Cliente { get; set; }
		public IFreteService Frete { get; set; }
		public ICarrinhoService Carrinho { get; set; }
		
		
		public Pedido (int _id, int _idCliente, IClienteService cliente, IFreteService frete, double _valorTotal, ICarrinhoService carrinho) {
			id = _id;
			Cliente = cliente;
			idCliente = _idCliente;
			Frete = frete;
			valorTotal = _valorTotal;
			Carrinho = carrinho;
		}

        public Pedido(int _id, int _idCliente, Cliente cliente, Frete frete, double _valorTotal, Carrinho carrinho)
        {
            this.id = _id;
            this.idCliente = _idCliente;
            this.cliente = cliente;
            this.frete = frete;
            this.valorTotal = _valorTotal;
            this.carrinho = carrinho;
        }

		public bool ValidaCliente(Cliente cliente)
		{
			if (cliente == null || id < 1)
			{
				return false;
			}
			return true;
		}

		public bool ValidaCarrinho(Carrinho carrinho)
		{
			if (carrinho == null || id < 1)
			{
				return false;
			}
			return true;
		}

		public double CalcularFrete()
		{
			double peso = frete.Peso;
			
			if (peso <= 5) {
				return frete.CalcularFrete() + 5;
			}
			else{
				if(peso  > 6 && peso <=10){
					return frete.CalcularFrete() + 10;
				}
				else{
					return frete.CalcularFrete() + 15;
				}
			}
		}
		
		public double CalculaValor()
		{
			double valor = carrinho.ValorTotal;
			double frete = carrinho.frete;
			
			double soma = valor+frete;
			return soma;
		}
	}
}
