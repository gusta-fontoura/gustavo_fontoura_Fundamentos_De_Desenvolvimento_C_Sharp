using System.Diagnostics.Metrics;

Console.WriteLine("---  Tempo Restante para Conclusão do Curso - Diferença Entre Datas ---");

DateTime date = GetDate("Digite a data atual (dd/mm/aaaa): ");

DateTime dataFormatura = new DateTime(2027, 06, 15);

DateTime hoje = DateTime.Today;

if (date > hoje)
{
    Console.WriteLine("Erro: A data informada não pode ser no futuro!");
}
else
{
    TimeSpan difference = dataFormatura - date;
    Console.WriteLine($"Diferença total em dias: {difference.TotalDays:F0} dias.");

    int years = 0;
    int months = 0;
    int days = 0;

    DateTime tempDate = date;

    while (tempDate.AddYears(1) <= dataFormatura)
    {
        years++;
        tempDate = tempDate.AddYears(1);
    }

    while (tempDate.AddMonths(1) <= dataFormatura)
    {
        months++;
        tempDate = tempDate.AddMonths(1);
    }

    while (tempDate.AddDays(1) <= dataFormatura)
    {
        days++;
        tempDate = tempDate.AddDays(1);
    }

    if (years == 0 && months <= 6)
    {

        Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
        Console.WriteLine($"Faltam {months} meses e {days} dias para sua formatura!");
    }else if (date > dataFormatura)
    {
        Console.WriteLine("Parabéns! Você já deveria estar formado!");
    }
    else
    {
        Console.WriteLine($"Faltam {years} anos, {months} meses e {days} dias para sua formatura!");
    }
}









    static DateTime GetDate(string prompt)
    {
        DateTime date;
        string input;
        while (true)
        {
            Console.Write(prompt);
            input = Console.ReadLine();

            date = DateTime.Parse(input);

            return date;
        }
    }
