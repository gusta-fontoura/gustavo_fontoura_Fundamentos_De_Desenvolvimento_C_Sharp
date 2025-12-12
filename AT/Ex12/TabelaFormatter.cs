using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {

            string formato = "| {0,-20} | {1,-15} | {2,-25} |";
            string linhaSeparadora = new string('-', 68);

            Console.WriteLine("\n" + linhaSeparadora);
            Console.WriteLine(string.Format(formato, "Nome", "Telefone", "Email"));
            Console.WriteLine(linhaSeparadora);

            foreach (var c in contatos)
            {
                string nome = c.Nome.Length > 20 ? c.Nome.Substring(0, 17) + "..." : c.Nome;
                string email = c.Email.Length > 25 ? c.Email.Substring(0, 22) + "..." : c.Email;

                Console.WriteLine(string.Format(formato, nome, c.Telefone, email));
            }
            Console.WriteLine(linhaSeparadora + "\n");
        }
    }
}
