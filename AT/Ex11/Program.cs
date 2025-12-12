namespace Ex11
{
    class Ex11
    {
        private const string CaminhoArquivo = "contatos.txt";
        static void Main(string[] args)
        {
            bool executando = true;

            while (executando)
            {
                ExibirMenu();
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarContato();
                        break;
                    case "2":
                        ListarContatos();
                        break;
                    case "3":
                        Console.WriteLine("Encerrando programa...");
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }

                if (executando)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            static void ExibirMenu()
            {
                Console.WriteLine("-- Gerenciador de Contatos --");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
            }

            static void AdicionarContato()
            {
                Console.WriteLine("\n-- Novo Contato --");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                // Validação simples para evitar linhas vazias
                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(telefone))
                {
                    Console.WriteLine("Erro: Nome e Telefone são obrigatórios.");
                    return;
                }

                Contato contato = new Contato(nome, telefone, email);

                string linha = contato.ToString();

                try
                {  
                    using (StreamWriter sw = new StreamWriter(CaminhoArquivo, true))
                    {
                        sw.WriteLine(linha);
                    }
                    Console.WriteLine("Contato cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao salvar o contato: {ex.Message}");
                }
            }

            static void ListarContatos()
            {
                Console.WriteLine("\n-- Contatos Cadastrados --");

                if (!File.Exists(CaminhoArquivo))
                {
                    Console.WriteLine("Nenhum contato cadastrado.");
                    return;
                }

                try
                {
                    using (StreamReader sr = new StreamReader(CaminhoArquivo))
                    {
                        string linha;
                        bool arquivoVazio = true;

                        while ((linha = sr.ReadLine()) != null)
                        {
                            arquivoVazio = false;
                            string[] dados = linha.Split(',');

                            if (dados.Length >= 3)
                            {
                                Console.WriteLine($"Nome: {dados[0]} | Telefone: {dados[1]} | Email: {dados[2]}");
                            }
                        }

                        if (arquivoVazio)
                        {
                            Console.WriteLine("Nenhum contato cadastrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao ler o arquivo: {ex.Message}");
                }
            }
        }
    }
}