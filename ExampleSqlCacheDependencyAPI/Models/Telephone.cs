using System.ComponentModel.DataAnnotations;

namespace ExampleSqlCacheDependencyAPI.Models;
public class Telephone
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Error")]
    public string Number { get; set; }

}