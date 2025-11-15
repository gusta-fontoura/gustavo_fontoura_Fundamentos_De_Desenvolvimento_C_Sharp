Console.WriteLine("Qual sua data de aniversário: (dd/mm/yyyy)");
String data = Console.ReadLine();

DateTime hoje = DateTime.Today;

DateTime dataParsed = DateTime.Parse(data);

DateTime aniversarioDoProximoAno = new DateTime(hoje.Year + 1, dataParsed.Month, dataParsed.Day);
Console.WriteLine(aniversarioDoProximoAno);

int contagensDosDias = 0;
DateTime diasQueEstamosContando = hoje;

if(hoje == dataParsed)
{
    Console.WriteLine("Seu aniversário é em 1 ano");
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

    
