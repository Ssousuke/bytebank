namespace bytebank.models
{
    public class ContaCorrente
    {
        public Cliente Titular { get; }
        public string Conta { get; }
        public string Agencia { get; }
        public int NumeroAgencia { get; }
        public double Saldo { get; private set; }
        public static int TotalDeContas { get; private set; }

        public ContaCorrente(Cliente titular, string conta, string agencia, int numeroAgencia)
        {
            Titular = titular;
            Conta = conta;
            Agencia = agencia;
            NumeroAgencia = numeroAgencia;
            TotalDeContas += 1;
        }

        public bool Saca(double valor)
        {
            /*
            * O valor de saque não deve ser maior que o valor do saldo
            * O valor de saque deve ser maior que 5.0
            */
            if (Saldo < valor || valor < 5.0)
            {
                return false;
            }

            Saldo -= valor;
            return true;
        }

        public void Deposita(double valor)
        {
            /*
            * O valor de deposito deve ser maior que 5.0
            */
            if (valor > 5.0)
            {
                Saldo += valor;
            }
        }

        public bool Transfere(ContaCorrente conta, double valor)
        {
            /*
            * O valor de transferencia não deve ser maior que o valor do saldo
            * O valor de transferencia deve ser maior que 5.0
            */
            if (Saldo < valor || valor < 5.0)
            {
                return false;
            }

            conta.Deposita(valor);
            Saca(valor);
            return true;
        }

        public override string ToString()
        {
            return "Titular: " + Titular + ", Conta: " + Conta +
                   ", agencia: " + Agencia + ", número da agencia: " +
                   NumeroAgencia + ", saldo: " + Saldo;
        }
    }
}