// Tracks calculated payroll instances over specified duration windows
using System;
using System.Collections.Generic;

namespace PayrollManager.Models
{
    public class PayrollCycle
    {
        public int Id { get; set; }

        public int PayrollTypeId { get; set; }
        public PayrollType PayrollType { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime PaymentDate { get; set; } // تاريخ الدفع

        // Totals saved dynamically for dashboard and report speeds
        public decimal TotalEarnings { get; set; }
        public decimal TotalDeductions { get; set; }
        public decimal TotalTaxes { get; set; }
        public decimal NetTotal { get; set; }

        // Navigation properties
        public ICollection<CycleEmployee> CycleEmployees { get; set; }
    }
}