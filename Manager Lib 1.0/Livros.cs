using System;

public class Livro
{
    public string Titulo { get; private set; } 
    public string Autor { get; private set; }
    public int NumPg { get; private set; }

    public Livro(string titulo, string autor, int numpg)
    {
        if (string.IsNullOrWhiteSpace(titulo)) throw new ArgumentException("O título não pode ser nulo");
        if (string.IsNullOrWhiteSpace(autor)) throw new ArgumentException("O autor não pode ser nulo");
        if (numpg <= 0) throw new ArgumentException("Páginas devem ser maior que zero");

        Titulo = titulo;
        Autor = autor;
        NumPg = numpg;
    }

    public string MostraInfo()
    {
        return $"📖 {Titulo} | Autor: {Autor} | Páginas: {NumPg}";
    }
}
