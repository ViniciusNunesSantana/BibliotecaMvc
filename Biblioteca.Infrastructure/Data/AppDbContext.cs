using Biblioteca.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infrastructure.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}

    public DbSet<Livro> Livros { get; set; }
}
