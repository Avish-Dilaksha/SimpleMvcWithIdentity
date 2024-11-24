namespace TestMvc.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int Age { get; set; }
        public int ManagerId { get; set; }
        public Manager? Manager { get; set; }

    }
}
