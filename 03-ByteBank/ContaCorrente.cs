public class ContaConrrente
{
    public string Titular;
    public int Agencia;
    public int Numero;
    public double Saldo = 100.00;

    public ContaConrrente() { }

    public ContaConrrente(string titular, int agencia, int numero, double saldo = 100)
    {
        this.Titular = titular;
        this.Agencia = agencia;
        this.Numero = numero;
        this.Saldo = saldo;
    }

    public override string ToString()
    {
        return $"Titular: {this.Titular}, Agencia: {this.Agencia}, Numero: {this.Numero}, Saldo: {this.Saldo.ToString("C2")}";
    }
}