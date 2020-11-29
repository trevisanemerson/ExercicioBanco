using System;
using System.Globalization;

namespace ExercicioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            char inicial;
            double quantidade;

            Conta c = new Conta();

            Console.Write("Entre o numero da conta: ");
            c.NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            c.Titular = Console.ReadLine();

            Console.Write("Haverá primeiro depósito? (s/n): ");
            inicial = char.Parse(Console.ReadLine());

            if (inicial == 's') {
                Console.Write("Digite o valor do dep. inicial: ");
                quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.AdicionarSaldo(quantidade);
            }

            Console.Write("Dados da Conta: " + c);
            
            Console.Write("Entre um valor para depósito: ");
            quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.AdicionarSaldo(quantidade);

            Console.WriteLine("Dados atualizados: " + c);

            Console.Write("Entre um valor para o saque: ");
            quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.RetirarSaldo(quantidade);

            Console.WriteLine("Dados atualizados: " + c);




        }
    }
}
