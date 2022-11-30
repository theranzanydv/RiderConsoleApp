namespace ConsoleApp3.Week5;

public class EmployeeModel
{
    public Guid id { get; set; } = new Guid();
    public string Name { get; set; }
    public string Address { get; set; }
    public int Number { get; set; }
    public bool IsTemp { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}