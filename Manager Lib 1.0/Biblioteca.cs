using System;
using System.Collections.Generic;

public class Biblioteca
{
    // A lista privada guarda o acervo. Ninguém de fora consegue apagar a lista.
    private List<Livro> _acervo;

    // A senha mestra do sistema (para simular a segurança)
    private const string CHAVE_AUTORIZADA = "admin123";

    public Biblioteca()
    {
        // Ao criar a biblioteca, já "populamos" a lista de forma profissional
        _acervo = new List<Livro>
        {
            new Livro("O Senhor dos Anéis", "Tolkien", 453),
            new Livro("Código Limpo", "Robert C. Martin", 400),
            new Livro("Arquitetura Limpa", "Robert C. Martin", 350)
        };
    }

    /// <summary>
    /// Valida a permissão e exibe o catálogo de livros.
    /// </summary>
    public void MostrarCatalogo(PermissaoCad credencial)
    {
        // 1. A VALIDAÇÃO
        if (credencial == null || credencial.Chave != CHAVE_AUTORIZADA)
        {
            Console.WriteLine($"[ACESSO NEGADO] Desculpe {credencial?.Nome}, sua chave é inválida.\n");
            return; // O 'return' expulsa o usuário do método e o código abaixo não é executado.
        }

        // 2. A EXIBIÇÃO (Se passou pela validação)
        Console.WriteLine($"\n[ACESSO PERMITIDO] Bem-vindo(a), {credencial.Nome}! Aqui está o nosso acervo:");
        Console.WriteLine(new string('-', 50)); // Desenha uma linha bonita
        
        foreach (var livro in _acervo)
        {
            Console.WriteLine(livro.MostraInfo());
        }
        Console.WriteLine(new string('-', 50) + "\n");
    }
}
