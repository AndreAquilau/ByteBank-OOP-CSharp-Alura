using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaConrrente contaDaGrabriela = new ContaConrrente();

            contaDaGrabriela.Titular = "Gabriela";
            contaDaGrabriela.Agencia = 863;
            contaDaGrabriela.Numero = 3652;
            contaDaGrabriela.Saldo = 30000.00;

            ContaConrrente contaDaGrabrielaCosta = new ContaConrrente();

            contaDaGrabriela.Titular = "Gabriela";
            contaDaGrabriela.Agencia = 863;
            contaDaGrabriela.Numero = 3652;
            contaDaGrabriela.Saldo = 30000.00;


            Console.WriteLine(contaDaGrabriela == contaDaGrabrielaCosta);

            contaDaGrabrielaCosta = contaDaGrabriela;

            Console.WriteLine(contaDaGrabriela == contaDaGrabrielaCosta);

            contaDaGrabriela.Saldo = 500;

            Console.WriteLine(contaDaGrabrielaCosta.Saldo);
        }
    }
}
