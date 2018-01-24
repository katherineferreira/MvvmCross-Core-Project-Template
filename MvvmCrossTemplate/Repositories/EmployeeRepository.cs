using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCrossTemplate.Contracts.Repository;
using MvvmCrossTemplate.Model;

namespace MvvmCrossTemplate.Repositories
{/// <summary>
/// The repository layer it's the part that’s doing the actual implementation of the retrieval of the data whether it is locally from a SQL database or from a remote service
/// </summary>
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> SearchEmployee(string employeeName, string employeeCharge, DateTime employeeStartDate)
        {
            throw new NotImplementedException();
        }
    }
}
