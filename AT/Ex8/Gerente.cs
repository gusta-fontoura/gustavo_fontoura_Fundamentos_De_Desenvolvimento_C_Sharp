using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    internal class Gerente : Funcionario
    {
        public Gerente(string nome, double salarioBase) 
            : base(nome, "Gerente", salarioBase * 1.2)
        {
            
        }
    }
}
