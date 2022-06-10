using AppCrud01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Domain.Interfaces
{
    public interface IClienteRepository
    {
        List<Cliente> GetAll();
        Cliente GetById(int id);
        void Create(Cliente cliente);
        public bool ValidaCliente(Cliente cliente);
    }
}
