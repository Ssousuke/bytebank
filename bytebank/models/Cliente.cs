namespace bytebank.models;

public class Cliente
{
    public string TitularNome { get; }
    public string TitularCpf { get; }
    public string TitularProfissao { get; }


    public Cliente(string titularNome, string titularCpf, string titularProfissao)
    {
        TitularNome = titularNome;
        TitularCpf = titularCpf;
        TitularProfissao = titularProfissao;
    }

    public override string ToString()
    {
        return "Nome: " + TitularNome +
               ", CPF: " + TitularCpf +
               ", Profissão: " + TitularProfissao;
    }
}