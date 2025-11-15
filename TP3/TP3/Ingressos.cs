using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Ingresso
    {

        //No contexto de shows, saber o nomeDoShow é importante, a partir disso, podemos definir preco e quantidade.
        //O preco é importante, isso que vai influenciar a procura do show.
        //Importante sempre manter a quantidadeDisponivel, num contexto de show é importante ter ingressos disponíveis e avisar quando não existe mais.


        public String nomeDoShow;
        public double preco;
        public int quantidadeDisponivel;

        
        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            //a Criação de cosntrutores é importante pois você consegue instanciar um objeto em uma linha só, semprecisar declarar atributo por atributo.
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }



        // os métodos de acesso são importante para proteger os dados da classe. Podendo ser acessados somente por um método especifico
        //trazendo mais segurança par ao codigo.
        public void GetNomeDoShow() 
        {
           Console.WriteLine(nomeDoShow);
        }
        public void GetPreco()
        {
            Console.WriteLine(preco);
        }
        public void GetQuantidadeDisponivel()
        {
            Console.WriteLine(quantidadeDisponivel);
        }

        public void SetNomeDoShow(string novoNome)
        {
            nomeDoShow = novoNome;
        }

        public void SetPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public void SetQuantidadeDisponivel(int novaQuantidadeDisponivel)
        {
            quantidadeDisponivel = novaQuantidadeDisponivel;
        }

        public void AlterarPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public void AlterarQuantidades(int novaQuantidade)
        {
            quantidadeDisponivel = novaQuantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Nome do Show: " + nomeDoShow);
            Console.WriteLine("Preço: R$" + preco.ToString("0.00"));
            Console.WriteLine("Ingressos Disponíveis: " + quantidadeDisponivel);
        }
    }
}
