using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_contaBancaria.net
{
    public class ContaBancaria
    {
       

        public double Saldo { get; private set; }
        public string Titular;
        public int NumeroConta{ get; private set; }
        

        public ContaBancaria( int numeroConta, string titular) { 
           NumeroConta = numeroConta;
            Titular = titular;
        }

        public ContaBancaria(double depositoInicial, int numeroConta, string titular) : this(numeroConta, titular)
        {
            deposito(depositoInicial);
        }
        public void deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void saque(double quantia)
        {
            Saldo -= quantia + 5;
        }
        public override string ToString()
        {
            return " CONTA: "
                + NumeroConta +
                ", TITULAR: " +
                 Titular +
                 ", SALDO: " +
                 Saldo.ToString("c");
        }

        
    }
}
