using AppCrud01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Domain.Entities
{
    public class ItensCarrinho
    {
        public int Id { get; set; }
        public int IdCarrinho { get; set; }
        public int IdProduto { get; set; }
        public double ValorUnitario { get; set; }
        public int Quantidade { get; set; }

        private IItensCarrinhoService itenscarrinho;
        private IItensCarrinhoService @object;

        public ItensCarrinho(IItensCarrinhoService @object)
        {
            this.@object = @object;
        }

        public bool GetItensCarrinhos(int idCar)
        {
            return true;
        }

        public bool ValidaIdCarProd(int idCar, int idProd)
        {
            if (idCar < 1 && idProd < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
