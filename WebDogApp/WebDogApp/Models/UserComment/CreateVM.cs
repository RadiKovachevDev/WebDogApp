using System.ComponentModel.DataAnnotations;
namespace WebDogApp.Models.UserComment;
public class CreateVM
{

    [Required, Display(Name = "Име")]
    public string UserName { get; set; } = null!;
    [Required, EmailAddress, Display(Name = "Имейл")]
    public string Email { get; set; } = null!;
    [Required, Display(Name = "Коментар")]
    public string Comment { get; set; } = null!;
}
