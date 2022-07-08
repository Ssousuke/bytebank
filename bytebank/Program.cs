using System.ComponentModel.DataAnnotations.Schema;
using bytebank.models;

namespace bytebank;

internal class Program
{
    static void Main(string[] args)
    {
        ContaCorrente conta = new ContaCorrente("Wesley Farias", "Santander", "Cental", 23, 100.0);
        ContaCorrente conta2 = new ContaCorrente("Wesley Silva", "Santander", "Cental", 23, 100.0);
        
        conta.Transfere(conta2, 50.0);
        Console.WriteLine(conta);
        Console.WriteLine(conta2);

        conta2.Transfere(conta, 50.0);
        Console.WriteLine(conta);
        Console.WriteLine(conta2);
    }
}