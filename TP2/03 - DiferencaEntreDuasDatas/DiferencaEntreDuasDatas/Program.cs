

Console.WriteLine("--- Calculadora de Diferença entre Datas ---");

DateTime date1 = GetDate("Digite a primeira data (formato dd/mm/aaaa): ");

DateTime date2 = GetDate("Digite a segunda data (formato dd/mm/aaaa): ");

DateTime startDate, endDate;
if (date1 < date2)
{
    startDate = date1;
    endDate = date2;
}
else
{
    startDate = date2;
    endDate = date1;
}

TimeSpan difference = endDate - startDate;
Console.WriteLine($"Diferença total em dias: {difference.TotalDays:F0} dias.");

int years = 0;
int months = 0;
int days = 0;

DateTime tempDate = startDate;

while (tempDate.AddYears(1) <= endDate)
{
    years++;
    tempDate = tempDate.AddYears(1);
}

// Calcula os meses completos
while (tempDate.AddMonths(1) <= endDate)
{
    months++;
    tempDate = tempDate.AddMonths(1);
}

// Calcula os dias restantes
while (tempDate.AddDays(1) <= endDate)
{
    days++;
    tempDate = tempDate.AddDays(1);
}

Console.WriteLine($"A diferença é de: {years} anos, {months} meses e {days} dias.");



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
