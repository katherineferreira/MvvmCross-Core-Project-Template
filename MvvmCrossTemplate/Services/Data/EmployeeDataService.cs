using MvvmCrossTemplate.Contracts.Repository;
using MvvmCrossTemplate.Contracts.Services;
using MvvmCrossTemplate.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvvmCrossTemplate.Services.Data
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeDataService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            var employee = await _employeeRepository.GetEmployeeDetails(employeeId);
            return employee;
        }

        public async Task<IEnumerable<Employee>> SearchEmployee(string employeeName, string employeeCharge, DateTime employeeStartDate)
        {
            return await _employeeRepository.SearchEmployee(employeeName, employeeCharge, employeeStartDate);
        }
    }
}
