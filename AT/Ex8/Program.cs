namespace Ex8
{
    class Ex8
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario("Gustavo Fontoura", "Estagiário", 1500);


            Gerente ger = new Gerente("Mozara Rodrigues", 1500.00);


            func.MostrarCargo();
            func.MostrarSalario();
            ger.MostrarCargo();
            ger.MostrarSalario();

        }
    }
}
