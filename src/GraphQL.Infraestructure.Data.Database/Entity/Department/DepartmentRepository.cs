using System.Collections.Generic;
using System.Linq;

namespace GraphQL.Infraestructure.Data.Database.Entity.Department
{
    public class DepartmentRepository
    {
        private readonly BlogContext _context;

        public DepartmentRepository(BlogContext context)
        {
            _context = context;
        }

        public DepartmentEntity Add(DepartmentEntity department)
        {
            _context.Add(department);
            _context.SaveChanges();
            return department;
        }

        public List<DepartmentEntity> Add(List<DepartmentEntity> departments)
        {
            _context.AddRange(departments);
            _context.SaveChanges();
            return departments;
        }

        public ICollection<DepartmentEntity> GetDepartmentByCompanyId(int companyId)
        {
            return _context.Departments.Where(x => x.CompanyId == companyId).ToList();
        }
    }
}
