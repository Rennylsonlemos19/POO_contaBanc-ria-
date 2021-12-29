using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_contaBancaria.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.WriteLine("ENTRE COM OS DADOS BANCARIOS: ");
            Console.WriteLine();

            Console.Write("NUMERO DA CONTA: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("TITULAR DA CONTA: ");
           string titular = Console.ReadLine();

            Console.Write("HAVERÁ DEPOSITO INICIAL ? " +
                "\nS:(sim)" +
                "\nN:(não)");
            char resp = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine();

            if( resp == 'S')
            {
                Console.Write("ENTRE COM O VALOR DE DEPOSITO INICIAl: ");
                double saldo = double.Parse(Console.ReadLine());
                 conta = new ContaBancaria(saldo,numero,titular);
            }
            else
            {
                conta = new ContaBancaria(numero,titular);
            }

            Console.WriteLine();

            Console.WriteLine("DADOS DA CONTA:");
            Console.WriteLine( conta);

            Console.WriteLine();
            Console.Write("ENTRE COM O VALOR DO DEPOSITO:");
            double deposito = double.Parse(Console.ReadLine());
            conta.deposito(deposito);
            Console.WriteLine("DADOS DA CONTA ATUALIZADOS:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("ENTRE COM O VALOR DO SAQUE:");
            double saque = double.Parse(Console.ReadLine());
            conta.saque(saque);
            Console.WriteLine("DADOS DA CONTA ATUALIZADOS:");
            Console.WriteLine(conta);
            Console.ReadKey();
        }
    }
}
