using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    internal class Funcionario
    {

        public String Nome;
        public String Cargo;
        public double SalarioBase;

        public Funcionario(string nome, string cargo, double salarioBase)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioBase = salarioBase;
        }

        public void MostrarSalario()
        {
            Console.WriteLine($"Salário: R$ {SalarioBase:f2}");
        }

        public void MostrarCargo()
        {
            Console.WriteLine($"Cargo: {Cargo}");
        }

    }
}
