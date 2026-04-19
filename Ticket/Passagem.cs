using System;
using System.Globalization;

/// <summary>
/// Classe profissional para representação de passagens aéreas.
/// </summary>
public class InfoPassagem
{
    public string Nome { get; private set; }
    public string Sobrenome { get; private set; }
    public string Assento { get; private set; }
    public string Destino { get; private set; }
    public DateTime DataVoo { get; private set; }
    public DateTime DataCompra { get; private set; }

    public InfoPassagem(string nome, string sobrenome, string assento, string destino, string dataVooInput)
    {
        // Validações básicas de preenchimento
        if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("O nome é obrigatório.");
        if (string.IsNullOrWhiteSpace(sobrenome)) throw new ArgumentException("O sobrenome é obrigatório.");
        if (string.IsNullOrWhiteSpace(assento)) throw new ArgumentException("O assento é obrigatório.");
        if (string.IsNullOrWhiteSpace(destino)) throw new ArgumentException("O destino é obrigatório.");

        // Validação de formato de data (dd/MM/yyyy)
        if (!DateTime.TryParseExact(dataVooInput, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida))
        {
            throw new ArgumentException("Formato de data inválido. Use dd/MM/yyyy (ex: 25/12/2026).");
        }

        // Validação de regra de negócio (Data no futuro)
        if (dataConvertida < DateTime.Today)
        {
            throw new ArgumentException("A data do voo não pode ser anterior a hoje.");
        }

        // Atribuição dos dados validados
        this.Nome = nome;
        this.Sobrenome = sobrenome;
        this.Assento = assento;
        this.Destino = destino;
        this.DataVoo = dataConvertida;
        this.DataCompra = DateTime.Now;
    }

    public void ImprimirBilhete()
    {
        Console.WriteLine("\n========== BILHETE DE EMBARQUE ==========");
        Console.WriteLine($"PASSAGEIRO: {Nome} {Sobrenome}");
        Console.WriteLine($"DESTINO:    {Destino}");
        Console.WriteLine($"ASSENTO:    {Assento}");
        Console.WriteLine($"DATA VOO:   {DataVoo:dd/MM/yyyy}");
        Console.WriteLine($"COMPRA EM:  {DataCompra:dd/MM/yyyy HH:mm}");
        Console.WriteLine("=========================================\n");
    }
}
