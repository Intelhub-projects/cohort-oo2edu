using SwiftEd.Models;
using System.Collections.Generic;

namespace SwiftEd.Interface.Repository
{
    public interface ILecturerRepository
    {
        Lecturer Create(Lecturer lecturer);
        Lecturer Update(Lecturer lecturer);
        Lecturer Get(int id);
        List<Lecturer> GetAll();
        void Delete(Lecturer lecturer);
        IEnumerable<Lecturer> GetSelectedLecturers(IList<int> ids);
    }
}