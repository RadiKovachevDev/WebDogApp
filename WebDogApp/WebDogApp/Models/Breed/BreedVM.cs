using System.ComponentModel.DataAnnotations;
namespace WebDogApp.Models.Breed;
public class BreedVM { public int Id {get;set;} [Required,Display(Name="Порода")] public string Name {get;set;}=null!; }
