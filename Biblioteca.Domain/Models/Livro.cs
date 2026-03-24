namespace Biblioteca.Domain.Models;
public class Livro
{
    public int Id { get; private set; }
    public string Titulo { get; private set; } = string.Empty;
    public string Autor { get; private set; } = string.Empty;
    public DateOnly Lancamento { get; private set; }
    public int Paginas { get; private set; }

    public Livro(string titulo, string autor, DateOnly lancamento, int paginas)
    {
        if (string.IsNullOrWhiteSpace(titulo))
            throw new ArgumentException("Titulo invalido!", nameof(titulo));

        if (string.IsNullOrWhiteSpace(autor))
            throw new ArgumentException("Autor invalido!", nameof(autor));

        if (lancamento > DateOnly.FromDateTime(DateTime.Now))
            throw new ArgumentException("Data nao pode ser no futuro", nameof(lancamento));

        if (paginas <= 0)
            throw new ArgumentException("Numeros de paginas invalida!", nameof(paginas));

        Titulo = titulo;
        Autor = autor;
        Lancamento = lancamento;
        Paginas = paginas;
    }
}
