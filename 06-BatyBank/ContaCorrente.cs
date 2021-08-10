﻿using System;
using System.Globalization;
using _06_ByteBank;
public class ContaCorrente
{
    private Cliente _cliente;
    private int _agencia;
    private int _numero;
    private double _saldo = 100;

    public Cliente Cliente { get; set; }

    public int Agencia { get; set; }

    public int Numero { get; set; } 

    public double Saldo
    {
        get
        {
            return this._saldo;
        }
        set
        {
            if (value < 0)
                return;

            this._saldo += value;
        }
    }


    public ContaCorrente() { }

    public override string ToString()
    {
        CultureInfo culture = new CultureInfo("pt-BR");
        string moneySaldo = this.Saldo.ToString("C2", culture);

        return $"Titular: {this.Cliente.Nome}, Agencia: {this.Agencia}, Número: {this.Numero}, Saldo: {moneySaldo}";
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
            if (this._saldo >= valor)
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