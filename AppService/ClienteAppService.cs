using AppCrud01.Application.ViewModel;
using AppCrud01.Domain.Entities;
using AppCrud01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Application.AppService
{
    public class ClienteAppService
    {
        private Cliente _cliente;
        IClienteService _clienteService;

        public ClienteAppService()
        {
        }

        public ClienteAppService(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public ClienteResultViewModel GetCliente(int id)
        {
            Cliente cliente = _clienteService.GetById(id);

            ClienteResultViewModel clienteNv = new ClienteResultViewModel();
            clienteNv.SetCpf(cliente.Cpf);
            return clienteNv;
        }
    }
}
