using GraphQL.Infraestructure.Data.Database.Entity.Employee;
using System.Collections.Generic;

namespace GraphQL.Infraestructure.Data.Database.Entity.Department
{
    public class DepartmentEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public ICollection<EmployeeEntity> Employees { get; set; }
    }
}
