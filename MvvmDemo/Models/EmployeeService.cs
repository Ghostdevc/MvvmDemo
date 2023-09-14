using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemo.Models
{
    public class EmployeeService
    {

        private static List<Employee> employees;

        public EmployeeService()
        {
            employees = new List<Employee>()
            {
                new Employee(){Id = 101 , Name = "Hasan" , Age = 25}
            };
        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        public bool Add(Employee employee)
        {
            if (21 < employee.Age && employee.Age < 58)
            {
                employees.Add(employee);
                return true;
            }
            else throw new ArgumentException("Invalid age");
            
        }

        public bool Update(Employee employeeToUpdate)
        {

            bool isUpdated = false;
            foreach (Employee employee in employees)
            {
                if (employeeToUpdate.Id == employee.Id)
                {
                    employee.Name = employeeToUpdate.Name;
                    employee.Age = employeeToUpdate.Age;
                    isUpdated = true;
                    break;
                }
            }
            return isUpdated;

        }

        public bool Delete(int id)
        {
            bool isDeleted = false;
            foreach (Employee employee in employees)
            {
                if (id == employee.Id)
                {
                    employees.RemoveAt(id);
                    isDeleted = true;
                    break;
                }
            }
            return isDeleted;

        }

        public Employee Search(int id)
        {
            return employees.FirstOrDefault(x => x.Id == id);
        }

    }
}
