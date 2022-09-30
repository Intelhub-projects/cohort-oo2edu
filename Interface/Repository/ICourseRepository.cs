using SwiftEd.Models;
using System.Collections.Generic;

namespace SwiftEd.Interface.Repository
{
    public interface ICourseRepository
    {
        Course Create(Course course);
        Course Update(Course course);
        Course Get(int id);
        List<Course> GetAll();
        void Delete(Course course);
        IEnumerable<Course> GetSelectedCourses(IList<int> ids);
    }
}