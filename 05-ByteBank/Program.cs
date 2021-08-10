using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente()
            {
                nome = "Gabriela",
                profissao = "Programadora Jr",
                cpf = "03510545290"
            };

            ContaCorrente contaGabriela = new ContaCorrente()
            {
                Cliente = gabriela,
                Agencia = 1562,
                Numero = 3652,
            };

            Console.WriteLine(gabriela.nome);
            Console.WriteLine(contaGabriela.Cliente.nome);

            gabriela.nome = "Gabriela Costa";

            Console.WriteLine(contaGabriela.ToString());
        }
    }
}
