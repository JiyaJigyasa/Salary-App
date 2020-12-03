using System;
using System.Collections.Generic;

#nullable disable

namespace SalaryWebApp
{
    public partial class Salary
    {
        public string PayBand { get; set; }
        public double BasicSalary { get; set; }
        public double? Hra { get; set; }
        public double? Ta { get; set; }
        public double? Da { get; set; }
        public double? Tds { get; set; }
    }
}
