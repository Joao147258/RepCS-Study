public class Program
{
    
    public static void Main()
    {
        Livros lista = new Livros("xxx", "xxx", 453);

        try
        {
            // Tentativa Valida
            PermicaoCad permicao = new PermicaoCad("Marta", "xcv3s");
            Console.WriteLine(lista.MostraInfo());

            // invalida
            PermicaoCad permic2 = new PermicaoCad("", "ww");

        }
        catch (ArgumentException arg)
        {
            Console.WriteLine($"Erro: {arg.Message}");
        }
    }
}