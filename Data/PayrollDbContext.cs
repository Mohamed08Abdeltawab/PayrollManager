using Microsoft.EntityFrameworkCore;

public class PayrollDbContext : DbContext
{
    public DbSet<Department> Departments { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<PayrollType> PayrollTypes { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<FinancialTransaction> FinancialTransactions { get; set; }
    public DbSet<PayrollCycle> PayrollCycles { get; set; }
    public DbSet<CycleEmployee> CycleEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Setting up the local SQLite database path inside the mobile storage
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "payroll_manager.db");
        optionsBuilder.UseSqlite($"Filename={dbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuring composite primary key for the junction table
        modelBuilder.Entity<CycleEmployee>()
            .HasKey(ce => new { ce.PayrollCycleId, ce.EmployeeId });

        // Defining relationships for CycleEmployee
        modelBuilder.Entity<CycleEmployee>()
            .HasOne(ce => ce.PayrollCycle)
            .WithMany(c => c.CycleEmployees)
            .HasForeignKey(ce => ce.PayrollCycleId);

        modelBuilder.Entity<CycleEmployee>()
            .HasOne(ce => ce.Employee)
            .WithMany(e => e.CycleEmployees)
            .HasForeignKey(ce => ce.EmployeeId);

        base.OnModelCreating(modelBuilder);
    }
}