namespace TestMvc.Models
{
    public class Manager
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public List<Employee>? Employees { get; set; }
    }
}
