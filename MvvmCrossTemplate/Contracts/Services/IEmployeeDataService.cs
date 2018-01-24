using MvvmCrossTemplate.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvvmCrossTemplate.Contracts.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<Employee>> SearchEmployee(string employeeName, string employeeCharge, DateTime employeeStartDate);

        Task<Employee> GetEmployeeDetails(int employeeId);
    }
}
