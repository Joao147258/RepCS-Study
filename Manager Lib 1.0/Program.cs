using System;

public class Program
{
    public static void Main()
    {
        // 1. Ligamos o sistema da Biblioteca
        Biblioteca minhaBiblioteca = new Biblioteca();

        try
        {
            // 2. Criamos as credenciais
            PermissaoCad usuarioValido = new PermissaoCad("Marta", "admin123");
            PermissaoCad usuarioInvalido = new PermissaoCad("João", "senhaErrada");

            // 3. Testamos o método
            minhaBiblioteca.MostrarCatalogo(usuarioInvalido); // Vai dar acesso negado
            
            minhaBiblioteca.MostrarCatalogo(usuarioValido);   // Vai mostrar os livros

        }
        catch (ArgumentException arg)
        {
            Console.WriteLine($"Erro na formatação dos dados: {arg.Message}");
        }
    }
}
