using Microsoft.EntityFrameworkCore;

namespace Registrar.Models
{
  public class RegistrarContext : DbContext
  {
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    
    // public DbSet<CourseStudent> CourseStudents { get; set; }

    public RegistrarContext(DbContextOptions options) : base(options) { }
  }
}