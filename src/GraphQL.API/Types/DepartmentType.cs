using GraphQL.Infraestructure.Data.Database.Entity.Department;
using GraphQL.Infraestructure.Data.Database.Entity.Employee;
using GraphQL.Types;


namespace GraphQL.API.Types
{
    public class DepartmentType : ObjectGraphType<DepartmentEntity>
    {
        public DepartmentType(EmployeeRepository employeeRepository)
        {
            Name = "Department";
            Field(x => x.Id).Description("Department Id");
            Field(x => x.CompanyId).Description("Company Id");
            Field(x => x.Name).Description("Department Name");

            Field("Employees",
                x => employeeRepository.GetEmployeeByDepartmentId(x.Id),
                nullable: true,
                type: typeof(ListGraphType<EmployeeType>)).Description("Department employees");
        }
    }
}
