
using Ex09;
namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            //para testar
            const string CaminhoArquivo = "estoque.txt";

            string opcao = "";
            Menu menu = new Menu();

            while (opcao != "3")
            {
                Console.Clear();

                menu.ShowMenu();

                Console.Write("Escolha uma opção: ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        InserirProduto();
                        break;
                    case "2":
                        ListarProdutos();
                        break;
                    case "3":
                        Console.WriteLine("Saindo do sistema.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }
            }

            static void InserirProduto()
            {
                Console.WriteLine("\n--- NOVO PRODUTO ---");
                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();

                try
                {
                    Console.Write("Quantidade: ");
                    int qtd = int.Parse(Console.ReadLine());

                    Console.Write("Preço Unitário: ");
                    double preco = double.Parse(Console.ReadLine());

                    Item novoProduto = new Item(nome, qtd, preco);

                    using (StreamWriter sw = File.AppendText(CaminhoArquivo))
                    {
                        sw.WriteLine(novoProduto.ToCsv());
                    }

                    Console.WriteLine("Produto salvo com sucesso no arquivo estoque.txt!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n[Erro] Digite apenas números válidos para quantidade e preço (use ponto para decimais).");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[Erro] Ocorreu um problema ao salvar: {ex.Message}");
                }

                Console.WriteLine("Pressione qualquer tecla para voltar...");
                Console.ReadKey();
            }

            static void ListarProdutos()
            {
                Console.WriteLine("\n--- LISTA DE PRODUTOS CADASTRADOS ---");

                if (!File.Exists(CaminhoArquivo))
                {
                    Console.WriteLine("Nenhum produto cadastrado (arquivo não encontrado).");
                    Console.ReadKey();
                    return;
                }

                try
                {
                    using (StreamReader sr = File.OpenText(CaminhoArquivo))
                    {
                        string linha;
                        bool arquivoVazio = true;

                        while ((linha = sr.ReadLine()) != null)
                        {
                            arquivoVazio = false;

                            string[] dados = linha.Split(',');

                            if (dados.Length == 4)
                            {
                                string nome = dados[0];
                                string qtd = dados[1];

                                double preco = double.Parse(dados[2]);

                                Console.WriteLine($"Produto: {nome} | Quantidade: {qtd} | Preço: {preco:f2}");
                            }
                        }

                        if (arquivoVazio)
                        {
                            Console.WriteLine("Nenhum produto cadastrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao ler arquivo: {ex.Message}");
                }

                Console.WriteLine("\nFim da lista. Pressione qualquer tecla...");
                Console.ReadKey();
            }
        }

    }
}



