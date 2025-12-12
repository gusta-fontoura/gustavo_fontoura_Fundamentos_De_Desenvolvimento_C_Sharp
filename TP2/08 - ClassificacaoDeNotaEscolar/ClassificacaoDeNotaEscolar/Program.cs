// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Desenvolva um programa que peça ao usuário uma nota de 0 a 10 e classifique-a como "Insuficiente < 6", "Regular 7 ", "Bom 8 9 " ou "Excelente10"

Console.WriteLine("Iniciando a classificação dos alunos");

Console.Write("Indique a nota do aluno: ");

double nota = double.Parse(Console.ReadLine());

if(nota < 7)
{
    Console.WriteLine("Classificação: Insuficiente");
}else if(nota == 7)
{
    Console.WriteLine("Classificação: Regular");
}else if(nota > 7 && nota < 10)
{
    Console.WriteLine("Classificação: Bom");
}
else
{
    Console.WriteLine("Classificação: Excelente");
}
