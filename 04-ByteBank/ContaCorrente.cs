public class ContaCorrente
{
    public string Titular;
    public int Agencia;
    public int Conta;
    public double Saldo = 100.00;

    public bool Sacar(double valor)
    {
        if(this.Saldo < valor)
        {
            return false;
        } else
        {
            return true;
        }
    }
}
