using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(agencia: 265, numero: 1516);
            ContaCorrente contaDaBabriela = new ContaCorrente(agencia: 265, numero: 1516);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
        }
    }
}
