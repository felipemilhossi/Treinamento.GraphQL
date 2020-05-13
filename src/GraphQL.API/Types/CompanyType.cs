using GraphQL.Infraestructure.Data.Database;
using GraphQL.Infraestructure.Data.Database.Entity;
using GraphQL.Types;

namespace GraphQL.API.Types
{
    public class CompanyType : ObjectGraphType<Company>
    {
        public CompanyType()
        {
            Name = "Company";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Company Id");
            Field(x => x.CNPJ).Description("Company CNPJ");
            Field(x => x.Name).Description("Company Name");
            Field(x => x.Phone).Description("Company Phone");
            Field(x => x.City).Description("Company City");
            Field(x => x.Site).Description("Company Site");
        }
    }
}
