using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaConrrente contaDoAndre = new ContaConrrente() { 
                Agencia = 1,
                Titular = "André",
                Numero = 2565,
                Saldo = 2500.00
            };

            Console.WriteLine(contaDoAndre.ToString());

            ContaConrrente contaDaGabriela = new ContaConrrente();

            contaDaGabriela.Titular = "Gabriela";

            Console.WriteLine(contaDaGabriela.ToString());
        }
    }
}
