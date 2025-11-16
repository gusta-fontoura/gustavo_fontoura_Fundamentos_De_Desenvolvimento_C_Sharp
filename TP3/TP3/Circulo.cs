using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Circulo
    {
        private double raio;

        public Circulo(double raio) {

            this.raio = raio;
        
        }

        public double CalcularArea()
        {
            double resultado = Math.PI * (raio * raio);

            Console.WriteLine("O Área do Circulo: " + resultado.ToString("0.00"));
            return resultado;
        }
    }
}
