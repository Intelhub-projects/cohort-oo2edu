using SwiftEd.Models;
using System.Collections.Generic;

namespace SwiftEd.Interface.Repository
{
    public interface IStudentRepository
    {
   
        Student Create(Student student);
        Student Update(Student student);
        Student Get(int id);
        List<Student> GetAll();
        void Delete(Student student);
        IEnumerable<Student> GetSelectedStudents(IList<int> ids);
    } 
    
}