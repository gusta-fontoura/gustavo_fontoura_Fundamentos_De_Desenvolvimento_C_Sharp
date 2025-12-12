using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("\n## Lista de Contatos");
            foreach (var c in contatos)
            {
                Console.WriteLine($"- **Nome:** {c.Nome}");
                Console.WriteLine($"- Telefone: {c.Telefone}");
                Console.WriteLine($"- Email: {c.Email}");
            }
            Console.WriteLine(); // Linha em branco
        }
    }
}
