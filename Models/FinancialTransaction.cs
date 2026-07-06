// Defines types of earnings, deductions, or taxes that can be applied
using System;
using System.Collections.Generic;

namespace PayrollManager.Models
{
    public class FinancialTransaction
    {
        public int Id { get; set; }
        public string Name { get; set; } // e.g., "توصيل", "تأخير", "شاي"
        public string Description { get; set; }

        public string TransactionType { get; set; } // "Earning", "Deduction", "Tax"
        public string CalculationType { get; set; } // "FixedAmount", "QuantityByPrice", "PercentageOfSalary"

        // Default system values
        public decimal DefaultAmount { get; set; }
        public decimal DefaultPrice { get; set; }
        public decimal DefaultQuantity { get; set; }
        public decimal DefaultPercentage { get; set; }
        public decimal DeductionLimit { get; set; } // حد الخصم
        public bool IsTaxable { get; set; } // خاضع للضريبة
    }
}