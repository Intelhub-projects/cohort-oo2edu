using Microsoft.EntityFrameworkCore;
using SwiftEd.Models;

namespace SwiftEd.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
         : base(options)
        {
        }

    

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseMaterial> CourseMaterials { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<CourseStudent> CourseStudents {get;set;}
        public DbSet<LecturerStudent> LecturerStudents {get;set;}
    }
}