public class Conta
{
    public int Codigo { get; }
    public double Saldo { get; private set; }

    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor)
    {
        if(valor > Saldo)
        {
            throw new ArgumentException("Não há saldo suficiente para esse saque");
        }

        if(valor <= 0.0)
        {
            throw new ArgumentException("Só é possível sacar valores maiores do que zero");
        }
        Saldo = Saldo - valor;
    }

    public void Depositar(double valor)
    {
        if(valor <= 0.0){
            throw new ArgumentException("Só é possível depositar valores maiores que 0");
        }

        Saldo = Saldo + valor;
    }

    public void Transferir(double valor, Conta conta)
    {
        if (valor <= 0.0)
        {
            throw new ArgumentException("O valor tem que ser maior que zero");
        }

        this.Sacar(valor);
        conta.Depositar(valor);
    }
}