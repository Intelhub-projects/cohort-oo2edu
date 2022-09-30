using SwiftEd.Context;
using SwiftEd.Models;
using System.Collections.Generic;
using System.Linq;

namespace SwiftEd.Implementation.Repository
{
    public class StudentRepository
    {
      private readonly ApplicationContext _context;

        public StudentRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Student Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public void Delete(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public Student Get(int id)
        {
           return _context.Students.Find(id);
         
        }

         public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public IEnumerable<Student> GetSelectedStudents(IList<int> ids)
        {
            return _context.Students.Where(a => ids.Contains(a.Id)).ToList();   
        }

        public Student Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return student;
        }  
    }
}