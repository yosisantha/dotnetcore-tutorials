using System;

namespace SimpleWebApi.Models
{
    public class EmployeeFilter
    {
        public string Name_Contains { get; set; }
        public double? Salary_From { get; set; }
        public double? Salary_To { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateOfBirth_From { get; set; }
        public DateTime? DateOfBirth_To { get; set; }
        public int? InternetPoints_From { get; set; }
        public int? InternetPoints_To { get; set; }
        public long? KarmaPoints_From { get; set; }
        public long? KarmaPoints_To { get; set; }
        public decimal? NetWorth_From { get; set; }
        public decimal? NetWorth_To { get; set; }
    }
}