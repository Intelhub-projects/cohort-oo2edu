using SwiftEd.Context;
using SwiftEd.Interface.Repository;
using SwiftEd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwiftEd.Implementations.Repository
{
    public class LecturerRepository : ILecturerRepository
    {
        private readonly ApplicationContext _context;

        public LecturerRepository(ApplicationContext context)
        {
           _context = context;   
        }

        public Lecturer Create(Lecturer lecturer)
        {
            _context.Lecturers.Add(lecturer);
            _context.SaveChanges();
            return lecturer;
        }

        public void Delete(Lecturer lecturer)
        {
            _context.Lecturers.Remove(lecturer);
            _context.SaveChanges();
        }

        public Lecturer Get(int id)
        {
           return _context.Lecturers.Find(id);
         
        }

        public List<Lecturer> GetAll()
        {
            return _context.Lecturers.ToList();
        }

        public IEnumerable<Lecturer> GetSelectedLecturers(IList<int> ids)
        {
            return _context.Lecturers.Where(a => ids.Contains(a.Id)).ToList();   
        }

        public Lecturer Update(Lecturer lecturer)
        {
            _context.Lecturers.Update(lecturer);
            _context.SaveChanges();
            return lecturer;
        }  
    }
}