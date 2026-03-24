using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Web.Models;

public class LivroViewModel
{
    [Required(ErrorMessage = "Titulo é obrigatorio")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Titulo tem que ter entre {2} e {1} caracteres")]
    public string Titulo { get;  set; } = string.Empty;

    [Required(ErrorMessage = "Autor é obrigatorio")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Autor tem que ter entre {2} e {1} caracteres")]
    public string Autor { get;  set; } = string.Empty;

    [Required(ErrorMessage = "Lancamento do livro é obrigatorio")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateOnly Lancamento { get;  set; }

    [Required(ErrorMessage = "Paginas do livro é obrigatorio")]
    [Range(1, 10000, ErrorMessage = "O livro tem que ter paginas entre {1} e {2}")]
    public int Paginas { get;  set; }
}
