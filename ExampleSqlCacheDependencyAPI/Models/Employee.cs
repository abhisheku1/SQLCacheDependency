namespace ExampleSqlCacheDependencyAPI.Models;

public class Employee
{
    public int Id { get; set; }
    public string EmployeeName { get; set; }
    public string EmployeSurname { get; set; }
    public int Age { get; set; }
    public int NumberId { get; set; }
    public Telephone Telephone { get; set; }
}