using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBTAnhKhoa.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees;
        public EmployeeRepository()
        {
            employees = new List<Employee>()
            {
                new Employee()
                {
                    ID = 1,
                    FullName = "Nhân Vũ",
                    Department = "IT",
                    Email = "nhanvu@gmail.com",
                    AvatarPath = "~/images/5656.jpg"
                },
                new Employee()
                {
                    ID = 2,
                    FullName = "Trâm Phan",
                    Department = "Business",
                    Email = "tramphan@gmail.com",
                    AvatarPath = "~/images/5656.jpg"
                }
            };
        }

        public IEnumerable<Employee> Gets()
        {
            return employees;
        }
    }
}
