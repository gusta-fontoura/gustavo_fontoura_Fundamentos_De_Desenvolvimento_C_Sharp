using System.Runtime.CompilerServices;

namespace MeuProjeto
{
    class Ex2
    {
        // O ponto de entrada da aplicação
        static void Main(string[] args)
        {
            //input do usuário para gravar o nome na variável.
            Console.Write("Qual o seu nome: ");
            String nome = Console.ReadLine();
            String novoNome = "";

            for (int i = 0; i < nome.Length; i++)//vou percorrer a string
            {

                //para cada char utilizo a a variável novoChar para modificar a variável c
                char c = nome[i];
                char novoChar = (char)(c + 2);
                //somando cada char a uma nova vaíavel para que seja exibida abaixo; não modificando a string original.
                novoNome += novoChar;
            }

            Console.WriteLine(novoNome);
        }
    }
}