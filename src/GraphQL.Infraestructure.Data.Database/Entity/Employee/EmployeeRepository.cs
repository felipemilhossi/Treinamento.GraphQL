using System.Collections.Generic;
using System.Linq;

namespace GraphQL.Infraestructure.Data.Database.Entity.Employee
{
    public class EmployeeRepository
    {
        private readonly BlogContext _context;

        public EmployeeRepository(BlogContext context)
        {
            _context = context;
        }

        public EmployeeEntity Add(EmployeeEntity employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public List<EmployeeEntity> Add(List<EmployeeEntity> employees)
        {
            _context.AddRange(employees);
            _context.SaveChanges();
            return employees;
        }

        public ICollection<EmployeeEntity> GetEmployeeByDepartmentId(int departmentId)
        {
            return _context.Employees.Where(x => x.DepartmentId == departmentId).ToList();
        }
    }
}
