// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("---- Converta sua temperatura em Celsius para Kelvin e Farenheit -----");

Console.WriteLine("Digite a temperatura em celsius para conversão: ");
double C = double.Parse(Console.ReadLine());


double F = C * 9 / 5 + 32;  
double K = C + 273.15;

Console.WriteLine("------------------------------- Resultado ----------------------------");
Console.WriteLine("Celsius: " + C.ToString("0") + "°C");
Console.WriteLine("Kelvin: " + K.ToString("0.00") + "K");
Console.WriteLine("Farenheit: " + F.ToString("0.00") + "°F");

Console.WriteLine("----------------------------------------------------------------------");