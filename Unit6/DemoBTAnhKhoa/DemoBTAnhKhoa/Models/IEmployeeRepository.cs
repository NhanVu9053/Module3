using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBTAnhKhoa.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> Gets();
    }
}
