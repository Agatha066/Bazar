using AppCrud01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Domain.Interfaces
{
    public interface IItensCarrinhoService
    {
        public bool GetItensCarrinhos(int idCar)
        {
            if(idCar < 1)
            {
                return false;
            }
            return true;
        }
    }
}
