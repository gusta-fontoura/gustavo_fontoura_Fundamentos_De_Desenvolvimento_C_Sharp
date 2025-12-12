using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class ContaBancaria
    {
        public String nome;
        private double saldo;

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
                saldo += valor;
                ExibirSaldo();
            }
            Console.WriteLine("O valor do depósito deve ser positivo!");
            ExibirSaldo();
        }

        public void Sacar(double valor) 
        { if (valor > 0)
            {
                if (saldo > valor)
                {
                    saldo -= valor;
                    Console.WriteLine($"Saque de R$ {valor:f2} realizado com sucesso!");
                    ExibirSaldo();
                }
                else
                {
                    Console.WriteLine($"Tentativa de saque: R$ {valor:F2}");
                    Console.WriteLine("Saldo insuficiente para realizar o saque!");
                    ExibirSaldo();
                }
            }
            else
            {
                Console.WriteLine("Valor incorreto para saque.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {saldo:F2}");
        }
    }
}
