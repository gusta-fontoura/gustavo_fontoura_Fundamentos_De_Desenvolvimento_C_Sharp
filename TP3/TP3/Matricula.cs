

namespace TP3
{
    internal class Matricula
    {
        private String nomeDoAluno;
        private String curso;
        private int numeroMatricula;
        private String situacao; 
        //-- por exemplo, "Ativa", "Trancada", "Concluída" etc.
        private String dataInicial; 

        public Matricula(String nomeDoAluno, String curso, int numeroMatricula, String situacao, String dataInicial)
        {
            this.nomeDoAluno = nomeDoAluno;
            this.curso = curso;
            this.numeroMatricula = numeroMatricula;
            this.situacao = situacao;
            this.dataInicial = dataInicial;
        }

        public void TrancarMatricula()
        {
            situacao = "Trancada";
        }

        public void ReativarMatricula()
        {
            situacao = "Ativa";
        }

        public void GetSituacao()
        {
            Console.WriteLine(situacao);
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine("Nome: " + nomeDoAluno);
            Console.WriteLine("Curso: " + curso);
            Console.WriteLine("Numero de Matricula: " + numeroMatricula);
            Console.WriteLine("Situação: " + situacao);
            Console.WriteLine("Data de Início: " + dataInicial);
        }
    }
}
