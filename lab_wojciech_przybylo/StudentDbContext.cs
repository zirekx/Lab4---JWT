using lab_wojciech_przybylo;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace lab_wojciech_przybylo
{
    public class StudentDbContext : IdentityDbContext<UserEntity, UserRole, int>
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; } = null!;
    }
}
