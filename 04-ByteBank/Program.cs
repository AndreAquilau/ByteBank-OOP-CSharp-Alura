using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Dynamic;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente()
            {
                Agencia = 3587,
                Numero = 3562,
                Titular = "Bruno"
            };

            ContaCorrente contaAndre = new ContaCorrente()
            {
                Agencia = 3652,
                Numero = 2613,
                Titular = "André"
            };

            Console.WriteLine(contaBruno.ToString());
            Console.WriteLine(contaAndre.ToString());

            contaBruno.Transferir(50.00, contaAndre);

            Console.WriteLine(contaBruno.ToString());
            Console.WriteLine(contaAndre.ToString());

            contaAndre.Transferir(50, contaBruno);

            Console.WriteLine(contaAndre.ToString());
            Console.WriteLine(contaBruno.ToString());

        }
    }
}
