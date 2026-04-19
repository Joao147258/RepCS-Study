public class Livros
{
    public string _Titulo { get; private set; } // get -> ler | set -> escrever
    public string _Autor { get; private set; }
    public int _NumPg { get; private set; }

    public Livros (string titulo, string autor, int numpg)
    {
        if (string.IsNullOrWhiteSpace(titulo))
        {
            throw new ArgumentException("o titulo não pode ser nulo");
        }
        if (string.IsNullOrWhiteSpace(autor))
        {
            throw new ArgumentException("Autor não pode ser nulo");
        }
        if (numpg <= 0)
        {
            throw new ArgumentException("Informe um valor de páginas valido");
        }

        _Titulo = titulo;
        _Autor = autor;
        _NumPg = numpg;


    }

    public string MostraInfo()
    {
        return $"Titulo: {_Titulo} | Autor: {_Autor} | Numero de paginas: {_NumPg}";
    }
}