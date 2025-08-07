using System.ComponentModel.DataAnnotations;

namespace apptarefas.Models;

public class Tipo
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string Descricao { get; set; } = null!;
}

public class ErrorViewModel
{
    [Required(ErrorMessage = "O  Título é obrigatório.")]
    [StringLength(100, ErrorMessage = "O Título deve ter no máximo 100 caracteres.")]
    public required string Titulo { get; set; }

    public string? RequestId { get; set; }
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}