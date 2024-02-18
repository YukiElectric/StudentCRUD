using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StudentCRUD.Data
{
    public class StudentContext : IdentityDbContext<User>
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        #region DbSet
        public DbSet<Student>? Students { get; set; }
        #endregion
    }
}
