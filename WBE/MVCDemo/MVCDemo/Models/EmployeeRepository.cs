//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace MVCDemo.Models
//{
//    public class EmployeeRepository : IEmployeeRepository
//    {
//        private IList<Employee> Employees;
//        public EmployeeRepository()
//        {
//            Employees = new List<Employee>()
//            {
//                new Employee()
//                {
//                    Id = 1,
//                    FullName = "Captain America",
//                    Department = Dept.IT,

//                    Email = "nhanvu@gmail.com",
//                    AvatarPath = "captian.png"
//                },
//                 new Employee()
//                {
//                    Id = 2,
//                    FullName = "Hulk",
//                    Department = Dept.HR,
//                    Email = "tramphan@gmail.com",
//                    AvatarPath = "hulk.png"
//                },
//                 new Employee()
//                {
//                    Id = 3,
//                    FullName = "Iron Man",
//                    Department = Dept.IT,
//                    Email = "nhungnguyen@gmail.com",
//                    AvatarPath = "ironmanchibi.jpg"
//                },
//                 new Employee()
//                {
//                    Id = 4,
//                    FullName = "Spider Man",
//                    Department = Dept.HR,
//                    Email = "quanvu@gmail.com",
//                    AvatarPath = "spidermanchibi.jpg"
//                },
//            };
//        }

//        public Employee Create(Employee employee)
//        {
//            employee.Id = Employees.Max(e => e.Id) + 1;
//            employee.AvatarPath = "~/images/hacker2.jpg";
//            Employees.Add(employee);
//            return employee;
//        }

//        public bool Delete(int id)
//        {
//            var delEmp = Get(id);
//            if(delEmp != null)
//            {
//                Employees.Remove(delEmp);
//                return true;
//            }
//            return false;
//        }

//        public Employee Edit(Employee employee)
//        {
//            var editEmp = Get(employee.Id);
//            editEmp.FullName = employee.FullName;
//            editEmp.Email = employee.Email;
//            editEmp.Department = employee.Department;
//            return editEmp;
//        }

//        public Employee Get(int id)
//        {
//            return Employees.FirstOrDefault(e => e.Id == id);
//        }

//        public IEnumerable<Employee> Gets()
//        {
//            return Employees;
//        }
//    }
//}
