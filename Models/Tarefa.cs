

using System.ComponentModel.DataAnnotations;
using apptarefas.Models;

public class Tarefa
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório.")]
    [MinLength(2, ErrorMessage = "O nome deve ter pelo menos 2 caracteres.")]
    [MaxLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
    [Display(Name = "Título")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "A descrição é obrigatória.")]
    [MinLength(5, ErrorMessage = "A descrição deve ter pelo menos 5 caracteres.")]
    [MaxLength(200, ErrorMessage = "A descrição não pode ter mais de 200 caracteres.")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; } = string.Empty;
    [DataType(DataType.DateTime)]
    [Display(Name = "Data de Criação")]
    public DateTime DataCriacao { get; set; }
    [DataType(DataType.DateTime)]
    [Display(Name = "Data de Conclusão")]
    public DateTime? DataConclusao { get; set; }
    public int TipoId { get; set; }
    public Tipo? Tipo { get; set; }
    public bool Concluida { get; set; } = false;

    public Tarefa()
    {
        DataCriacao = DateTime.Now;
    }

}