using System;

public class PermissaoCad
{
    public string Nome { get; private set; }
    public string Chave { get; private set; }

    public PermissaoCad(string nome, string chave)
    {
        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(chave))
        {
            throw new ArgumentException("Nome e Chave são obrigatórios.");
        }

        Nome = nome;
        Chave = chave;
    }
}
