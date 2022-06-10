using AppCrud01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud01.Domain.Entities
{
    public class Frete
    {
        public int Cep { get; set; }
        public double Peso { get; set; }
		

        public IFreteService freteService;

        public Frete(IFreteService _freteService)
        {
            freteService = _freteService;
        }

        public double CalcularFrete()
        {
            //return freteService.CalcularFrete();
			
			//adicionalFrete => Taxa
			
			if (Peso <= 5) {
				return freteService.CalcularFrete() + 5;
			}
			else{
				if(Peso  > 6 && Peso<=8){
					return freteService.CalcularFrete() + 10;
				}
				else{
					return freteService.CalcularFrete() + 15;
				}
			}
        }
		
		
    }
}
