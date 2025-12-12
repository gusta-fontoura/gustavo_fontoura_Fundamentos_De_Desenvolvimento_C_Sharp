using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    internal class Contato
    {

        private String Nome;
        private String Telefone;
        private String Email;

        public Contato(string nome, string telefone, string email) 
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nome},{Telefone},{Email}";
        }

    }
}
