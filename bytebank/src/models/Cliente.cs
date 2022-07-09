namespace bytebank.models;

public struct Cliente
{
    public string TitularNome { get; set; }
    public string TitularCpf { get; set; }
    public string TitularProfissao { get; set; }


    public override string ToString()
    {
        return "Nome: " + TitularNome +
               ", CPF: " + TitularCpf +
               ", Profissão: " + TitularProfissao;
    }
}