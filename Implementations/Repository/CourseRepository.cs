using System.Collections.Generic;
using System.Linq;
using SwiftEd.Context;
using SwiftEd.Interface.Repository;
using SwiftEd.Models;

namespace SwiftEd.Implementation.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationContext _context;

        public CourseRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Course Create(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return course;
        }

        public void Delete(Course course)
        {
            _context.Courses.Remove(course);
            _context.SaveChanges();
        }

        public Course Get(int id)
        {
            return _context.Courses.Find(id);
        }

        public List<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public IEnumerable<Course> GetSelectedCourses(IList<int> ids)
        {
            return _context.Courses.Where(a => ids.Contains(a.Id)).ToList();
        }

        public Course Update(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
            return course;
        }
    }
}