using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;


        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Hridoy", Department = Dept.HR, Email = "hridoy@gmail.com"},
                new Employee() { Id = 2, Name = "Hasan", Department = Dept.IT, Email = "hasan@gmail.com"},
                new Employee() { Id = 3, Name = "Mahmudul", Department = Dept.IT, Email = "mahmudul@gmail.com"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id =  _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
