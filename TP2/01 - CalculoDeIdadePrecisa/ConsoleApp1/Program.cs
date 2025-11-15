using System.Data;
using System.Runtime.CompilerServices;
using System.Text; // Para Encoding.UTF8

public class DateDifferenceCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Qual sua data de aniversário: (dd/mm/yyyy)");
        String data = Console.ReadLine();

        DateTime agora = DateTime.Now;

        DateTime dataParsed = DateTime.Parse(data);

        int ano = dataParsed.Year;
        int mes = dataParsed.Month;
        int dia = dataParsed.Day;
        int agoraAno = agora.Year;
        int agoraMes = agora.Month;
        int agoraDia = agora.Day;
        int anoResultado;
        int mesResultado;
        int diaResultado;


        if (dia > agoraDia)
        {
            int diasDoMes = DateTime.DaysInMonth(agoraAno, agoraMes - 1);
            diaResultado = (diasDoMes + agoraDia) - dia;
            agoraMes--;
        }
        else 
        {
            diaResultado = agoraDia - dia;
        }

        if (mes > agoraMes) 
        {
            mesResultado = (mes + agoraMes) - mes;
            ano--;
        }
        else
        {
            mesResultado= agoraMes - mes;
        }

        anoResultado = agoraAno - ano;

        Console.WriteLine("Ano: " + anoResultado);
        Console.WriteLine("Meses: " + mesResultado);
        Console.WriteLine("Dias: " + diaResultado);

    }
}