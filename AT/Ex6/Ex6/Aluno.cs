

namespace Ex6
{
    internal class Aluno
    {
        private String nome;
        private int matricula;
        private String curso;
        private double mediaDeNotas;

        public Aluno(string nome, int matricula, string curso, double mediaDeNotas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.curso = curso;
            this.mediaDeNotas = mediaDeNotas;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Matrícula: " + matricula);
            Console.WriteLine("Curso: " + curso);
            Console.WriteLine("Média de Notas: " + mediaDeNotas);
        }

        public String VerificarAprovacao()
        {
            if (mediaDeNotas < 7)
            {
                return "Reprovado";
            }
            return "Aprovado";
        }
    }
}
