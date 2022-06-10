using AppCrud01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Domain.Interfaces
{
    public interface IClienteService
    {
      
        List<Cliente> GetAll();
        Cliente GetById(int id);
        void Add(Cliente cliente);
		public bool ValidaCliente(Cliente cliente);
    
    }
}
