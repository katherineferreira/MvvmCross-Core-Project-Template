using System;

namespace MvvmCrossTemplate.Model
{
    public class Employee : BaseModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime EmployeeStartDate { get; set; }
        public string EmployeeCharge { get; set; }
        public int EmployeeAge { get; set; }
        public DateTime EmployeeBirthDay { get; set; }
    }
}
