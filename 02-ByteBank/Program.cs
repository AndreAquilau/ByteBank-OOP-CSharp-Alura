using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaConrrente conta = new ContaConrrente();

            conta.Titular = "Gabriela";

            conta.Saldo = 200;

            Console.WriteLine(conta.Titular);

            Console.WriteLine(conta.Numero);

            Console.WriteLine(conta.Saldo);
        }
    }
}
