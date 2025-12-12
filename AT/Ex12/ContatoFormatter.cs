using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class ContatoFormatter
    {
        public virtual void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("Exibindo contatos de forma genérica...");
        }
    }
}
