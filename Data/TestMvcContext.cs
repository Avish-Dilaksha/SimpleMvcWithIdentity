using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestMvc.Data
{
    public class TestMvcContext : IdentityDbContext<IdentityUser>
    {
        public TestMvcContext (DbContextOptions<TestMvcContext> options)
            : base(options)
        {
        }

        public DbSet<TestMvc.Models.Manager> Manager { get; set; } = default!;
        public DbSet<TestMvc.Models.Employee> Employee { get; set; } = default!;
    }
}
