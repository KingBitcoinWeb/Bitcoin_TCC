using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bitcoin_TCC.Models
{
    public class BitcoinCalcular
    {
        public double resultadoBitcoin { get; set; }

        public double resultadoDoCalculo()
        {
            double valorDoBitcoin = 10000;
            double valorEntrada = 20000;
            double resultado = 0;

            resultado = (((valorEntrada) * 1) / valorDoBitcoin);

            return resultado;
        }
    }
}
