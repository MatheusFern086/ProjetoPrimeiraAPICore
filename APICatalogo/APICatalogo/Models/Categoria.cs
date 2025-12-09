using System.ComponentModel.DataAnnotations;

namespace APICatalogo.Models;
[Tags("Categorias")]
public class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    //relacionamento 1:N (uma categoria para muitos produtos)
    public ICollection<Produto>? Produtos { get; set; }

    public Categoria()
    {
        Produtos = new List<Produto>();
    }
}
