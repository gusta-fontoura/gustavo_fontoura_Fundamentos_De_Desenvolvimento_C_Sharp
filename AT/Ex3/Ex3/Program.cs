using System.Linq.Expressions;

class Ex3
{
    // O ponto de entrada da aplicação
    static void Main(string[] args)
    {
        //variáveis para os números da equação.
        int numero1, numero2, operacao;
        while (true)
        {
            Console.Write("Primeiro número: ");
            if (int.TryParse(Console.ReadLine(), out numero1))
            {
                break;
            }
            else
            {
                Console.WriteLine("Erro: Digite apenas números inteiros.");
            }

        }

        while (true)
        {
            Console.Write("Segundo número: ");
            if (int.TryParse(Console.ReadLine(), out numero2))
            {
                break;
            }
            else
            {
                Console.WriteLine("Erro: Digite apenas números inteiros.");
            }
        }

        while (true)
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            if (int.TryParse(Console.ReadLine(), out operacao) && operacao >= 1 && operacao <= 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Erro: Digite apenas números inteiros.");
            }
        }

        int resultado = 0;
        switch (operacao)
        {
            case 1:
                resultado = numero1 + numero2;
                Console.WriteLine("Resultado: " + resultado);
                break;
            case 2:
                resultado = numero1 - numero2;
                Console.WriteLine("Resultado: " + resultado);
                break;
            case 3:
                resultado = numero1 * numero2;
                Console.WriteLine("Resultado: " + resultado);
                break;
            case 4:
                if (numero1 == 0 || numero2 == 0)
                {
                    Console.WriteLine("Divisões por 0 não são permitidas");
                    break;
                }
                else if(numero1 < numero2)
                {
                    double resultadoDouble = (double)numero1 / numero2;
                    Console.WriteLine("Resultado: " + resultadoDouble.ToString("0.00"));
                    break;
                }
                else
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                }
            default:
                Console.WriteLine("Programa fechando - Número inválido");
                break;
        }
    }
}