// Defines the payroll template or types configured in settings
public class PayrollType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    // Navigation properties
    public ICollection<PayrollCycle> Cycles { get; set; }
}