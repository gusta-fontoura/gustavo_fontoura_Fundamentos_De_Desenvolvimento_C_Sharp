// See https://aka.ms/new-console-template for more information

using TP3;

static void Main(string[] args)
{
    Ex1Escola infnet = new Ex1Escola();

    infnet.nome = "Instituto Infnet";

    infnet.adicionarAlunos(20);
    Console.WriteLine("---------------Exercício 1.---------------");
    Console.WriteLine("Nome: " + infnet.nome);
    Console.WriteLine("Alunos: " + infnet.alunos);



    Console.WriteLine("-----------Exercício 2 - 6: Ingressos---------");


    Ingresso djavan = new Ingresso("Djavan - O Show de Reveillon", 56.00, 100);


    djavan.AlterarQuantidades(35);
    djavan.AlterarPreco(152.00);
    djavan.ExibirInformacoes();

    Console.WriteLine("---Get and Set - Ingressos---");

    djavan.SetNomeDoShow("Djavan - O Show do Reveillon de Copacabana 2025");
    djavan.GetNomeDoShow();
    djavan.SetPreco(200.00);
    djavan.GetPreco();
    djavan.SetQuantidadeDisponivel(1000);
    djavan.GetQuantidadeDisponivel();

    Ingresso duaLipa = new Ingresso("Dua Lipa - Incredible Show on Rio de Janeiro", 450.00, 200);
    duaLipa.ExibirInformacoes();

    Console.WriteLine("---------------Exercício 7 - 9.---------------");
    Matricula gustavo = new Matricula("Gustavo Fontoura", "ADS", 20250278, "Ativa", "01/04/2025");
    gustavo.ExibirInformacoes();
    gustavo.TrancarMatricula(); 
    gustavo.GetSituacao();
    gustavo.ReativarMatricula();
    gustavo.GetSituacao();
    
}   

Main(args);



