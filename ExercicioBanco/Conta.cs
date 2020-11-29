using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioBanco
{
    class Conta
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(int numero, string titular, double saldo) {
            NumeroConta = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public Conta()
        {
        }

        public double AdicionarSaldo(double quantidade) {
            Saldo += quantidade;
            return Saldo;            
        }
        public double RetirarSaldo(double quantidade) {
            double taxa = 5.00;
            Saldo -= quantidade;
            Saldo -= taxa;
            return Saldo;
        }
        public override string ToString()
        {
            return "Conta " + NumeroConta
            + " , Titular: " + Titular
            + " , Saldo: " + Saldo.ToString("F2");
        }
    }
}
