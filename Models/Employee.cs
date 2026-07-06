// Stores all detailed information regarding an employee
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string IdentityNumber { get; set; } // الهوية
    public DateTime EmploymentDate { get; set; } // تاريخ التوظيف
    public decimal BaseSalary { get; set; } // الراتب الأساسي

    // Foreign Keys to organizational structure
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

    public int PositionId { get; set; }
    public Position Position { get; set; }

    // Personal & Additional info from the screen options
    public DateTime? BirthDate { get; set; }
    public string MaritalStatus { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string ContractType { get; set; } // نوع العقد
    public string PaymentFrequency { get; set; } // تكرار الدفع
    public string SalaryType { get; set; } // نوع الراتب
    public string BankName { get; set; }
    public string BankAccountNumber { get; set; }

    // Navigation properties for junction tables
    public ICollection<CycleEmployee> CycleEmployees { get; set; }
}