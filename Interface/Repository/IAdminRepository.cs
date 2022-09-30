using SwiftEd.Models;
using System.Collections.Generic;

namespace SwiftEd.Interface.Repository
{
    public interface IAdminRepository
    {
        Admin Create(Admin admin);
        Admin Update(Admin admin);
        Admin Get(int id);
        List<Admin> GetAll();
        void Delete(Admin admin);
        IEnumerable<Admin> GetSelectedAdmins(IList<int> ids);
    }
}