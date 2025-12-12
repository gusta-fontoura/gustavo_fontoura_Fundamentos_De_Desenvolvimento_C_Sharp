Console.WriteLine("Qual sua data de aniversário: (dd/mm/yyyy)");
String data = Console.ReadLine();

DateTime hoje = DateTime.Today;

DateTime dataParsed = DateTime.Parse(data);

if(dataParsed.Year > hoje.Year)
{
    Console.WriteLine("Você não nasceu ainda!");
}
else
{
    DateTime aniversarioDoProximoAno = new DateTime(hoje.Year + 1, dataParsed.Month, dataParsed.Day);

    DateTime aniversarioDoAno = new DateTime(hoje.Year, dataParsed.Month, dataParsed.Day);

    int contagensDosDias = 0;
    DateTime diasQueEstamosContando = hoje;

    if (hoje == dataParsed)
    {
        Console.WriteLine("Seu aniversário é em 1 ano");
    }
    else if (dataParsed.Month >= hoje.Month && dataParsed.Day >= hoje.Day)
    {
        while (hoje < aniversarioDoAno)
        {
            contagensDosDias++;
            hoje = hoje.AddDays(1);
        }
        if (contagensDosDias <= 7)
        {
            Console.WriteLine("Falta muito pouco para o seu aniversário, só mais alguns dias!!!!");
        }
        Console.WriteLine("Dias: " + contagensDosDias);
    }
    else
    {
        while (hoje < aniversarioDoProximoAno)
        {
            contagensDosDias++;
            hoje = hoje.AddDays(1);
        }
        Console.WriteLine("Dias: " + contagensDosDias);
    }
}




