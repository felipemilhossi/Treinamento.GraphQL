using GraphQL.Infraestructure.Data.Database.Entity.Employee;
using GraphQL.Types;

namespace GraphQL.API.Types
{
    public class EmployeeType : ObjectGraphType<EmployeeEntity>
    {
        public EmployeeType()
        {
            Name = "Employee";
            Field(x => x.Id).Description("Employee Id");
            Field(x => x.DepartmentId).Description("Department Id");
            Field(x => x.Name).Description("Employee Name");
            Field(x => x.Email).Description("Employee Email");
            Field(x => x.Salary).Description("Employee Salary");
        }
    }
}
