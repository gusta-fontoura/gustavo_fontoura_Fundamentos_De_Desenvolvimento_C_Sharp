using System.Runtime.CompilerServices;

namespace Ex12
{
    class Ex12
    {

        private const string CaminhoArquivo = "contatos.txt";
        static void Main(string[] args)
        {
            if (!File.Exists(CaminhoArquivo))
            {
                File.Create(CaminhoArquivo).Close();
            }

            while (true)
            {
                Console.WriteLine(" -- GERENCIADOR DE CONTATOS --");
                Console.WriteLine("1. Adicionar Contato");
                Console.WriteLine("2. Exibir Contatos");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarContato();
                        break;
                    case "2":
                        MenuExibicao();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static void AdicionarContato()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Telefone: ");
            string fone = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            using (StreamWriter sw = File.AppendText(CaminhoArquivo))
            {
                sw.WriteLine($"{nome};{fone};{email}");
            }
            Console.WriteLine("Contato salvo com sucesso!\n");
        }

        static void MenuExibicao()
        {
            List<Contato> lista = LerContatosDoArquivo();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.\n");
                return;
            }

            Console.WriteLine("\n-- Formato de exibição --");
            Console.WriteLine("1. Markdown");
            Console.WriteLine("2. Tabela");
            Console.WriteLine("3. Texto Puro");
            Console.Write("Opção: ");
            string escolha = Console.ReadLine();

            ContatoFormatter formatter = null;

            switch (escolha)
            {
                case "1":
                    formatter = new MarkdownFormatter();
                    break;
                case "2":
                    formatter = new TabelaFormatter();
                    break;
                case "3":
                    formatter = new RawTextFormatter();
                    break;
                default:
                    Console.WriteLine("Formato inválido. Usando Texto Puro por padrão.");
                    formatter = new RawTextFormatter();
                    break;
            }

            formatter.ExibirContatos(lista);
        }

        static List<Contato> LerContatosDoArquivo()
        {
            var lista = new List<Contato>();

            if (!File.Exists(CaminhoArquivo)) return lista;

            var linhas = File.ReadAllLines(CaminhoArquivo);
            foreach (var linha in linhas)
            {
                var partes = linha.Split(';');
                if (partes.Length >= 3)
                {
                    lista.Add(new Contato(partes[0], partes[1], partes[2]));
                }
            }
            return lista;
        }
    }
}
