using AppCrud01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cep { get; set; }
        

        public Cliente(int id, string nome, string cep, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Cep = cep;
        }
		
		public bool ValidaCliente (IClienteService cliente){
			return true;
		}
    }
}
