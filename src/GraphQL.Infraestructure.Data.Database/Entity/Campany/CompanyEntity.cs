﻿using GraphQL.Infraestructure.Data.Database.Entity.Department;
using System.Collections.Generic;

namespace GraphQL.Infraestructure.Data.Database.Entity.Campany
{
    public class CompanyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string CNPJ { get; set; }
        public string Phone { get; set; }
        public string Site { get; set; }
        public ICollection<DepartmentEntity> Departments { get; set; }
    }
}
