Console.WriteLine("Iniciando a verificação de impar ou par");

Console.Write("Indique um número para checagem: ");

int numero = int.Parse(Console.ReadLine());

if(numero % 2 == 0)
{
    Console.WriteLine(numero + " é Par.");
}
else
{
    Console.WriteLine(numero + " é Ímpar.");
}
