using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    internal class Item
    {
        public string Nome { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public double PrecoUnitario { get; set; }

        public Item(string nome, int quantidadeEmEstoque, double precoUnitario)
        {
            Nome = nome;
            QuantidadeEmEstoque = quantidadeEmEstoque;
            PrecoUnitario = precoUnitario;

        }

        public string ToCsv()
        {
            // Usa InvariantCulture para garantir que o preço use ponto (.) e não vírgula
            return $"{Nome},{QuantidadeEmEstoque},{PrecoUnitario:f2}";
        }

        // Método para formatar a exibição no console
        public override string ToString()
        {
            return $"Produto: {Nome} | Quantidade: {QuantidadeEmEstoque} | Preço: {PrecoUnitario:f2}";
        }
    }
}
