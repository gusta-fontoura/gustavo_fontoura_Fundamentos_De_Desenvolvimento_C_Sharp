namespace Ex6
{
    class Ex6
    {
        static void Main(string[] args)
        {
            Aluno gustavo = new Aluno("Gustavo", 123445, "Análise e desenvolvimento de sistemas", 9.5);
            Aluno maria = new Aluno("Maria Gabriela", 99382, "Engenharia de Dados", 6.2);

            gustavo.ExibirDados();
            Console.WriteLine(gustavo.VerificarAprovacao()); 
            maria.ExibirDados();
            Console.WriteLine(maria.VerificarAprovacao());

        }
    }
}
