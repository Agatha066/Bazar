using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Application.ViewModel
{
    public class ClienteResultViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cep { get; set; }
       
        public string GetCpf()
        {
            return Cpf;
        }
        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }
    }
}
