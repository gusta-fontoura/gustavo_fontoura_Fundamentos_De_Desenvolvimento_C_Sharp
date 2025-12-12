// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//IMC PESO
//Magreza	< 18.5	< 54.1 Kg
//Normal	18.5 a 24.9	54.1 a 72.8 Kg
//Sobrepeso	24.9 a 30	72.8 a 87.7 Kg
//Obesidade	> 30	> 87.7 Kg

Console.WriteLine("Iniciando o cálculo do IMC: ");
Console.Write("Indique a sua altura em cm: ");
double altura = double.Parse(Console.ReadLine())/100;
Console.Write("Indique o seu peso em kg: ");
double peso = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);

if (imc < 18.5)
{
    Console.WriteLine("Seu IMC: " + imc.ToString("0.00"));
    Console.WriteLine("Seu IMC indica: Magreza");
}
else if (imc >= 18.5 && imc <= 24.9)
{
    Console.WriteLine("Seu IMC: " + imc.ToString("0.00"));
    Console.WriteLine("Seu IMC indica: Normal");
}
else if (imc >= 24.9 && imc <= 30)
{
    Console.WriteLine("Seu IMC: " + imc.ToString("0.00"));
    Console.WriteLine("Seu IMC indica: Sobrepeso");
}
else
{
    Console.WriteLine("Seu IMC: " + imc.ToString("0.00"));
    Console.WriteLine("Seu IMC indica: Obesidade");
}