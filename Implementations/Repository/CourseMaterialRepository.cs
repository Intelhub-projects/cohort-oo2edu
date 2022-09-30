using System.Collections.Generic;
using System.Linq;
using SwiftEd.Context;
using SwiftEd.Interface.Repository;
using SwiftEd.Models;

namespace SwiftEd.Implementation.Repository
{
    public class CourseMaterialRepository : ICourseMaterialRepository
    {
        private readonly ApplicationContext _context;
        public CourseMaterialRepository(ApplicationContext context)
        {
            _context = context;
        }

        public CourseMaterial Create(CourseMaterial courseMaterial)
        {
           _context.CourseMaterials.Add(courseMaterial);
           _context.SaveChanges();
           return courseMaterial;
        }

        public void Delete(CourseMaterial courseMaterial)
        {
            _context.CourseMaterials.Remove(courseMaterial);
            _context.SaveChanges();    
        }

        public CourseMaterial Get(int id)
        {
           return _context.CourseMaterials.Find(id);
        }

        public List<CourseMaterial> GetAll()
        {
           return _context.CourseMaterials.ToList();
        }

        public IEnumerable<CourseMaterial> GetSelectedCourseMaterial(IList<int> ids)
        {
            return _context.CourseMaterials.Where(a => ids.Contains(a.Id)).ToList();
        }

        public CourseMaterial Update(CourseMaterial courseMaterial)
        {
            _context.CourseMaterials.Update(courseMaterial);
            _context.SaveChanges();
            return courseMaterial;
        }
    }
}