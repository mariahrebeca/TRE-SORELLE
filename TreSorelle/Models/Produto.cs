using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreSorelle.Models;

[Table("Produto")]
public class Produto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição Resumida")]
    [StringLength(300, ErrorMessage = "A Descrição Resumida deve possuir no máximo 300 caracteres")]
    public string DescricaoResumida { get; set; }

     [StringLength(300)]
    public string Foto { get; set; }

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(6,2)")]
    [Required(ErrorMessage = "Informe o Preço de Venda")]
    public decimal Preco { get; set; }

    [Display(Name = "Nota do Produto")]
    public byte? Nota { get; set; }
    public ICollection<ProdutoAvaliacao> Avaliacoes { get; set; }
}