using bytebank.models;

namespace bytebank;

internal class Program
{
    static void Main(string[] args)
    {
        // Cliente cliente = new Cliente("Wesley Farias", "555.555.555-00", "Analista de Sistemas");
        // Cliente cliente2 = new Cliente("Wesley Silva", "555.555.555-00", "Analista de Sistemas");
        Cliente cliente = new();
        Cliente cliente2 = new();

        cliente.TitularNome = "Wesley Farias";
        cliente.TitularCpf = "555.555.555-00";
        cliente.TitularProfissao = "Analista de Sistemas";

        cliente2.TitularNome = "Wesley Silva";
        cliente2.TitularCpf = "555.555.555-00";
        cliente2.TitularProfissao = "Analista de Sistemas";

        ContaCorrente conta = new ContaCorrente(cliente, "Santander", "Cental", 23);
        ContaCorrente conta2 = new ContaCorrente(cliente2, "Santander", "Cental", 23);

        conta.Deposita(200.0);
        conta.Transfere(conta2, 20.0);
        Console.WriteLine(conta);
        Console.WriteLine(conta2);

        var totalDeContas = ContaCorrente.TotalDeContas;
        Console.WriteLine($"Total de Contas: {totalDeContas}");
    }
}