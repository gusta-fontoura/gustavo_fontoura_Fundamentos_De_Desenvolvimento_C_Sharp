Random random = new Random();

int secreto = random.Next(101);

string msg = "Digite o número de 0 a 100: ";

Console.Write(msg);

int palpite = int.Parse(Console.ReadLine());
int count = 0;


while (secreto != palpite)
{
    
    
    if (secreto > palpite)
    {
        Console.WriteLine("Palpite baixo!!!");
    }
    else
    {
        Console.WriteLine("Palpite alto!!!");
    }
    Console.Write("Palpite novamente: ");
    palpite = int.Parse(Console.ReadLine());
    count++;
}

Console.WriteLine("Você acertou o número em "+ count+ " tentativas!! Resposta: " + palpite);





