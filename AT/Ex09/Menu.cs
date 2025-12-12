using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    internal class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("\n=== GESTÃO DE PRODUTOS ===");
            Console.WriteLine("1. Inserir Produto");
            Console.WriteLine("2. Listar Produtos");
            Console.WriteLine("3. Sair");
            Console.Write("Digite a opção desejada: ");
        }
    }
}
