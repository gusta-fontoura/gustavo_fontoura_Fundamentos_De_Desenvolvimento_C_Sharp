using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine(); // Espaço antes de começar
            foreach (var c in contatos)
            {
                Console.WriteLine($"Nome: {c.Nome} | Telefone: {c.Telefone} | Email: {c.Email}");
            }
            Console.WriteLine();
        }
    }
}
