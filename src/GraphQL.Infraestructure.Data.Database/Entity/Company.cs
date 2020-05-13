using System;
using System.Collections.Generic;

namespace GraphQL.Infraestructure.Data.Database.Entity
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string CNPJ { get; set; }
        public string Phone { get; set; }
        public string Site { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
