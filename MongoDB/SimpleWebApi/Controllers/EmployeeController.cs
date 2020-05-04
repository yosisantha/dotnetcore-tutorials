using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleWebApi.Models;

namespace SimpleWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Employee Get(string id)
        {
            var employee = new Employee();
            employee.Id = id;
            return employee;
        }

        [HttpGet("filter")]
        public List<Employee> Filter([FromBody]EmployeeFilter filter)
        {
            var employeeA = new Employee();
            employeeA.Name = filter.Name_Contains;
            employeeA.Salary = filter.Salary_From ?? 0;
            employeeA.IsActive = filter.IsActive ?? false;
            employeeA.DateOfBirth = filter.DateOfBirth_From ?? DateTime.Now;
            employeeA.InternetPoints = filter.InternetPoints_From ?? 0;
            employeeA.KarmaPoints = filter.KarmaPoints_From ?? 0;
            employeeA.NetWorth = filter.NetWorth_From ?? 0;
            var employeeB = new Employee();
            employeeB.Name = filter.Name_Contains;
            employeeB.Salary = filter.Salary_To ?? 0;
            employeeB.IsActive = filter.IsActive ?? false;
            employeeB.DateOfBirth = filter.DateOfBirth_To ?? DateTime.Now;
            employeeB.InternetPoints = filter.InternetPoints_To ?? 0;
            employeeB.KarmaPoints = filter.KarmaPoints_To ?? 0;
            employeeB.NetWorth = filter.NetWorth_To ?? 0;

            return new List<Employee>() { employeeA, employeeB };
        }

        [HttpPost("create")]
        public Employee Create(Employee employee)
        {
            return employee;
        }

        [HttpPost("update")]
        public Employee Update(Employee employee)
        {
            return employee;
        }

        [HttpPost("delete")]
        public string Delete([FromBody]string id)
        {
            return id;
        }
    }
}
