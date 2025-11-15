Console.Write("Indique um número para a contagem regressiva: ");
int numero = int.Parse(Console.ReadLine());

for(int i = numero; i >= 0; i--)
{
    Console.WriteLine("Contador: " + i);
}