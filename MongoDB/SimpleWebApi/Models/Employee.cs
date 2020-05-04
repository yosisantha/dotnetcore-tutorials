using System;

namespace SimpleWebApi.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int InternetPoints { get; set; }
        public long KarmaPoints { get; set; }
        public decimal NetWorth { get; set; }
    }
}