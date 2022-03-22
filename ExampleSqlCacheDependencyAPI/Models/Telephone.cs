namespace ExampleSqlCacheDependencyAPI.Models;
public class Telephone
{
    public int Id { get; set; }
    public string Number { get; set; }
    public ICollection<Employee> Employees { get; set; }
}