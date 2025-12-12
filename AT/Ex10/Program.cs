namespace Ex10
{
    class Ex10
    {

        static void Main(string[] args)
        {

            Random rand = new Random();
            int aleatorio = rand.Next(1, 51);
           
            int tentativas = 0;

            bool acertou = false;

            while (tentativas < 6 && !acertou)
            {
                Console.WriteLine("Digite seu palpite de 1 a 50");
                int palpite = int.Parse(Console.ReadLine());
                try
                {
                    if (palpite < 1 || palpite > 50)
                    {
                        throw new ArgumentOutOfRangeException("O número deve ser entre 1 e 50!");
                    }

                    if (palpite == aleatorio)
                    {

                        Console.WriteLine("Você acertou o número!!");
                        acertou = true;
                        break;
                    } else 
                    {
                        Console.WriteLine($"\nQue pena, palpite incorreto, tente novamente...");
                    }
                    tentativas++;
                }

                catch (ArgumentOutOfRangeException ex)
                {

                    Console.WriteLine($"Erro de Intervalo: {ex.ParamName}");
                }
                
            }
            if (!acertou)
            {
                Console.WriteLine($"\nQue pena, suas tentativas acabaram. O número era: {aleatorio}");
            }
        }

        
                          

    }
}