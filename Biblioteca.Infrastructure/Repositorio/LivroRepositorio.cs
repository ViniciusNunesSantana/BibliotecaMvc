using Biblioteca.Domain.Interface;
using Biblioteca.Domain.Models;
using Biblioteca.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infrastructure.Repositorio;
public class LivroRepositorio : ILivroRepository
{
    private readonly AppDbContext _dbContext;

    public LivroRepositorio(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Livro> AdicionarLivro(Livro livro)
    {

        await _dbContext.Livros.AddAsync(livro);
        await _dbContext.SaveChangesAsync();
        return livro;

    }

    public async Task<IEnumerable<Livro>> ListaLivros()
    {
        return await _dbContext.Livros.ToListAsync();
    }
}
