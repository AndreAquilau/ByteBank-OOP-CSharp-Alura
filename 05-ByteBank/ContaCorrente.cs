using System;
using System.Globalization;
using _05_ByteBank;
public class ContaCorrente
{
    public Cliente Cliente;
    public int Agencia;
    public int Numero;
    private double _saldo = 100;
    public double Saldo { get => this._saldo; }

    public ContaCorrente() { }

    public override string ToString()
    {
        CultureInfo culture = new CultureInfo("pt-BR");
        string moneySaldo = this.Saldo.ToString("C2", culture);

        return $"Titular: {this.Cliente.nome}, Agencia: {this.Agencia}, Número: {this.Numero}, Saldo: {moneySaldo}";
    }

    public bool Sacar(double valor)
    {
        try
        {

            if (this.Saldo >= valor)
            {
                this._saldo -= valor;
                return true;
            }
            else
            {
                throw new Exception("Saldo Insuficiênte");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
            return false;
        }
        finally
        {
            Console.WriteLine("Operação Concluída");
        }

    }

    public void Depositar(double valor)
    {
        try
        {
            if (valor > 0)
            {
                this._saldo += valor;
            }
            else
            {
                throw new Exception("Valor De Depósito Inválido!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
        finally
        {
            Console.WriteLine("Operação Concluída");
        }
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        try
        {
            if(this._saldo >= valor)
            {
                this.Sacar(valor);
                contaDestino.Depositar(valor);
                return true;
            }
            else
            {
                throw new Exception("Valor De Transferência Inválido!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
            return false;
        }
        finally
        {
            Console.WriteLine("Operação Concluída");
        }
    }
}