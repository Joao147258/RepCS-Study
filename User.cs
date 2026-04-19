public class PermicaoCad
{
    public string _Nome { private set; get; }
    public string _Chave { private set; get; }

    // Definindo o comportamento 

    public PermicaoCad(string nome, string chave)
    {
        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(chave))
        {
            throw new ArgumentException("Dados Invalidos");
        }

        _Chave = chave;
        _Nome = nome;

    }
}

