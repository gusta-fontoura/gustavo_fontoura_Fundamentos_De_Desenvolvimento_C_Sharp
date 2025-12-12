using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Esfera
    {
        private double raio;


        public Esfera(double raio)
        {

            this.raio = raio;

        }

        public double CalcularVolume()
        {
            double resultado = (4.0 / 3.0) * Math.PI * (raio * raio * raio);
            Console.WriteLine("O volume da esfera: " + resultado.ToString("0.00"));
            return resultado;
        }
    }
}
