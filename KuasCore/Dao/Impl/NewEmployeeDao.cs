
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : IEmployeeDao
    {

        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee();
            employee.Id = "1";
            employee.Name = "雄大";
            employee.Age = 1;
            employees.Add(employee);

            Employee employees1 = new Employee();
            employees1.Id = "2";
            employees1.Name = "雄大大";
            employees1.Age = 2;
            employees.Add(employees1);

            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employees = new Employee();
            employees.Id = "1101137222";
            employees.Name = "朱啟宏";
            employees.Age = 22;
            return employees;
        }

    }
}
