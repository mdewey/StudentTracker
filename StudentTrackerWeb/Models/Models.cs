using Microsoft.EntityFrameworkCore;

namespace StudentTracker.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        { }

        public DbSet<Student> Students { get; set; }
       
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }   
        public string Reason { get; set; }
        
    }

   
}