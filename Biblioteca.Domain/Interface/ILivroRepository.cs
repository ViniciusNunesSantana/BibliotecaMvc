using Biblioteca.Domain.Models;

namespace Biblioteca.Domain.Interface;
public interface ILivroRepository
{
    Task<Livro> AdicionarLivro(Livro livro);
    Task<IEnumerable<Livro>> ListaLivros();
}
