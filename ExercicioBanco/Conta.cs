using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioBanco
{
    class Conta
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular, double saldo) {
            NumeroConta = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public Conta() { 
        }

        public void AdicionarSaldo(double quantidade) {
            Saldo += quantidade;          
        }
        public void RetirarSaldo(double quantidade) {
            Saldo -= quantidade + 5.00;            
        }
        public override string ToString()
        {
            return "Conta " + NumeroConta
            + " , Titular: " + Titular
            + " , Saldo: " + Saldo.ToString("F2");
        }
    }
}
