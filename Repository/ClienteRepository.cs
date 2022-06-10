using AppCrud01.Domain.Entities;
using AppCrud01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Infra.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public void Create(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool ValidaCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
