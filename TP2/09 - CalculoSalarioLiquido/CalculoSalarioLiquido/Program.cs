internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Qual seu salário bruto?");
        double bruto = double.Parse(Console.ReadLine());
        double liquido = 0;
        double desconto;

        const double SALARIO1 = 2259.20;
        const double SALARIO2 = 2826.65;
        const double SALARIO3 = 3751.05;
        const double SALARIO4 = 4664.68;


        if (bruto < SALARIO1)
        {
            desconto = 0;
            liquido = bruto;
            Console.WriteLine("-----------Resultado----------");
            Console.WriteLine("Bruto: R$" + bruto.ToString("0,00"));
            Console.WriteLine("Liquido: R$" + liquido.ToString("0,00"));
            Console.WriteLine("Desconto: R$" + desconto.ToString("0.00"));
            Console.WriteLine("Alíquota: Isento");
        }
        else if (bruto >= SALARIO1 && bruto < SALARIO2)
        {
            desconto = bruto * 0.075;
            liquido = bruto - desconto;
            Console.WriteLine("-----------Resultado----------");
            Console.WriteLine("Bruto: R$" + bruto.ToString("0,00"));
            Console.WriteLine("Liquido: R$" + liquido.ToString("0,00"));
            Console.WriteLine("Desconto: R$" + desconto.ToString("0.00"));
            Console.WriteLine("Alíquota: 7,5%");
        }
        else if (bruto >= SALARIO2 && bruto < SALARIO3)
        {
            desconto = bruto * 0.15;
            liquido = bruto - desconto;
            Console.WriteLine("-----------Resultado----------");
            Console.WriteLine("Bruto: R$" + bruto.ToString("0,00"));
            Console.WriteLine("Liquido: R$" + liquido.ToString("0,00"));
            Console.WriteLine("Desconto: R$" + desconto.ToString("0.00"));
            Console.WriteLine("Alíquota: 15%");
        }
        else if (bruto >= SALARIO3 && bruto < SALARIO4)
        {
      
            desconto = bruto * 0.225;
            liquido = bruto - desconto;
            Console.WriteLine("-----------Resultado----------");
            Console.WriteLine("Bruto: R$" + bruto.ToString("0,00"));
            Console.WriteLine("Liquido: R$" + liquido.ToString("0,00"));
            Console.WriteLine("Desconto: R$" + desconto.ToString("0.00"));
            Console.WriteLine("Alíquota: 22,5%");
        }
        else
        {
            desconto = bruto * 0.275;
            liquido = bruto - desconto;
            Console.WriteLine("-----------Resultado----------");
            Console.WriteLine("Bruto: R$" + bruto.ToString("0,00"));
            Console.WriteLine("Liquido: R$" + liquido.ToString("0,00"));
            Console.WriteLine("Desconto: R$" + desconto.ToString("0.00"));
            Console.WriteLine("Alíquota: 27,5%");
        }

    }
}



/*Até R$ 2.259,20	zero	zero
De R$ 2.259,21 até R$ 2.826,65	7,5%	R$ 169,44
De R$ 2.826,66 até R$ 3.751,05	15%	R$ 381,44
De R$ 3.751,06 até R$ 4.664,68	22,5%	R$ 662,77
Acima de R$ 4.664,68	27,5%	R$ 896,00*/

