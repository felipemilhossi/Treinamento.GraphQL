using GraphQL.Infraestructure.Data.Database.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Infraestructure.Data.Database
{
    public class CompanyRepository
    {
        private readonly BlogContext _context;

        public CompanyRepository(BlogContext context)
        {
            _context = context;
        }

        public async Task<List<Company>> Get(CompanyFilter Filter)
        {
            var query = _context.Companies.AsTracking();
            if (Filter.Id.HasValue && Filter.Id > 0)
                query = query.Where(w => w.Id == Filter.Id);
            if (!string.IsNullOrEmpty(Filter.Name))
                query = query.Where(w => Filter.Name.Contains(w.Name));
            return await query.ToListAsync();
        }

        public Company Add(Company company)
        {
            _context.Add(company);
            _context.SaveChanges();
            return company;
        }

        public Company Update(Company dbCompany, Company company)
        {

            dbCompany.Name = company.Name;
            dbCompany.Phone = company.Phone;

            _context.SaveChanges();

            return dbCompany;
        }

        public Company GetById(int id)
        {
            return _context.Companies.FirstOrDefault(f => f.Id == id);
        }

        public void Remove(Company company)
        {
            _context.Remove(company);
            _context.SaveChanges();
        }
    }
}
