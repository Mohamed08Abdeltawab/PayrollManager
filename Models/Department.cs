// Represents the departments within the organization
public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    // Navigation property for EF Core
    public ICollection<Employee> Employees { get; set; }
}