using GraphQL.API.Types;
using GraphQL.Infraestructure.Data.Database;
using GraphQL.Types;

namespace GraphQL.API.Queries
{
    public class BlogQuery : ObjectGraphType<object>
    {
        public BlogQuery(CompanyRepository repositorio)
        {
            Field<ListGraphType<CompanyType>>("company",
                arguments: new QueryArguments(new QueryArgument[]
                {
                    new QueryArgument<IdGraphType>{Name="id"},
                    new QueryArgument<StringGraphType>{Name="name"}
                }),
                resolve: contexto =>
                {
                    var filtro = new CompanyFilter()
                    {
                        Id = contexto.GetArgument<int>("id"),
                        Name = contexto.GetArgument<string>("name"),
                    };
                    return repositorio.Get(filtro);
                }

            );
        }
    }
}
