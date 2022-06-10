using AppCrud01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Domain.Entities
{
    public int IdProd { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string Fornecedor { get; set; }

        public Produto(int id, string nome, int quant, double preco, string forn)
        {
            IdProd = id;
            Nome = nome;
            Quantidade = quant;
            Preco = preco;
            Fornecedor = forn;
        }
}
