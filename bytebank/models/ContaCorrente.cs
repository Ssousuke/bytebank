namespace bytebank.models
{
    internal class ContaCorrente
    {
        private string titular;
        private string conta;
        private string agencia;
        private int numero_agencia;
        private double saldo;

        public ContaCorrente(string titular, string conta, string agencia, int numero_agencia, double saldo)
        {
            this.titular = titular;
            this.conta = conta;
            this.agencia = agencia;
            this.numero_agencia = numero_agencia;
            this.saldo = saldo;
        }

        public string Titular => titular;

        public string Conta => conta;

        public string NomeAgencia => agencia;

        public int NumeroAgencia => numero_agencia;

        public double Saldo => saldo;


        public bool Saca(double valor)
            /*
             * O valor de saque não deve ser maior que o valor do saldo
             * O valor de saque deve ser maior que 5.0
             */
        {
            if (saldo < valor || valor < 5.0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Deposita(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }

        public bool Transfere(ContaCorrente conta, double valor)
        {
            if (saldo < valor || valor < 5.0)
            {
                return false;
            }
            else
            {
                conta.Deposita(valor);
                this.Saca(valor);
                return true;
            }
        }

        public override string ToString()
        {
            return "Titular: " + titular + ", conta: " + conta +
                   ", agencia: " + agencia + ", número da agencia: " +
                   numero_agencia + ", saldo: " + saldo;
        }
    }
}