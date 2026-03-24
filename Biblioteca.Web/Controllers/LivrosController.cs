using Biblioteca.Domain.Interface;
using Biblioteca.Domain.Models;
using Biblioteca.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Web.Controllers;
public class LivrosController : Controller
{
    private readonly ILivroRepository _livroRepository;

    public LivrosController(ILivroRepository livroRepository)
    {
        _livroRepository = livroRepository;
    }

    public async Task<IActionResult> Lista()
    {
        IEnumerable<Livro> livros = await _livroRepository.ListaLivros();
        return View(livros);
    }

    public IActionResult Criar()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Criar(LivroViewModel livroView)
    {

        if (!ModelState.IsValid)
            return View(livroView);

        try
        {
            Livro livro = new Livro
                (
                livroView.Titulo,
                livroView.Autor,
                livroView.Lancamento,
                livroView.Paginas
                );

            await _livroRepository.AdicionarLivro(livro);
            return RedirectToAction(nameof(Lista));
        }
        catch(ArgumentException ex)
        {
            ModelState.AddModelError("", ex.Message);
            
           return View(livroView);
        }
    }
}
