// Junction table linking employees to specific cycles, preserving calculation snapshots
public class CycleEmployee
{
    public int PayrollCycleId { get; set; }
    public PayrollCycle PayrollCycle { get; set; }

    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

    // Snapshot amounts computed for this specific cycle run
    public decimal EarningsSnapshot { get; set; }  // إجمالي الإيرادات للموظف
    public decimal DeductionsSnapshot { get; set; } // إجمالي الخصومات للموظف
    public decimal TaxesSnapshot { get; set; }      // إجمالي الضرائب للموظف
    public decimal NetSalarySnapshot { get; set; }   // الصافي النهائي للموظف
}