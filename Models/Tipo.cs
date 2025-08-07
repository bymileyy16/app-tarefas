using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

public class Tipo
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório.")]
    [MinLength(2, ErrorMessage = "O nome deve ter pelo menos 2 caracteres.")]
    [MaxLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
    public string? Nome { get; set; } = null!;
    [Required(ErrorMessage = "A descrição é obrigatória.")]
    [MinLength(5, ErrorMessage = "A descrição deve ter pelo menos 5 caracteres.")]
    [MaxLength(500, ErrorMessage = "A descrição não pode ter mais de 500 caracteres.")]
    public string Descricao { get; set; } = null!;

   public ICollection<Tarefa> Tarefas { get; set; } = new List<Tarefa>();

}
