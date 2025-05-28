using System.ComponentModel.DataAnnotations;

namespace Controlecontatos.Models;

public class ContatoModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Informe o nome do contato")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Informe o email do contato")]
    [EmailAddress(ErrorMessage = "O email informado não é válido!")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Informe o telefone do contato")]
    [Phone(ErrorMessage = "O celular informado não é válido!")]
    public string Celular { get; set; }
    
}