using System.Collections.Generic;
using SwiftEd.Models;

namespace SwiftEd.Interface.Repository
{
    public interface ICourseMaterialRepository
    {
        
        CourseMaterial Create(CourseMaterial courseMaterial);
        CourseMaterial Update(CourseMaterial courseMaterial);
        CourseMaterial Get(int id);
        List<CourseMaterial> GetAll();
        void Delete(CourseMaterial courseMaterial);
        IEnumerable<CourseMaterial> GetSelectedCourseMaterial(IList<int> ids);
    }
}