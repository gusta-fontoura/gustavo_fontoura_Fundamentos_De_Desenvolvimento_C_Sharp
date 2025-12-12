namespace Ex7
{
    class Ex7
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1 = new ContaBancaria();
            conta1.nome = "Gustavo";

            conta1.Depositar(2000);
            conta1.Sacar(3000);
            conta1.Sacar(-200);
            conta1.Sacar(0);
            conta1.Sacar(200.82);
        }
    }
}
