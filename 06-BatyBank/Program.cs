using System;

namespace _06_BatyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.SetSaldo = -500;

            Console.WriteLine(conta.GetSaldo);

            Console.ReadKey();
        }
    }
}
