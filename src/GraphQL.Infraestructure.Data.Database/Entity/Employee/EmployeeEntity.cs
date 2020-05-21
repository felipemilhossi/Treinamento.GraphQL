namespace GraphQL.Infraestructure.Data.Database.Entity.Employee
{
    public class EmployeeEntity
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
    }
}
