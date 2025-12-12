Console.Write("Indique o número para taboada: ");
int numero = int.Parse(Console.ReadLine());
int resultado;
for (int i = 1; i < 11; i++)
{
    resultado = numero * i;
    Console.WriteLine("Tabuada: " + i +  " X " + numero + " = " + resultado);
}
