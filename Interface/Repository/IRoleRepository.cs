using SwiftEd.Models;
using System.Collections.Generic;

namespace SwiftEd.Interface.Repository
{
    public interface IRoleRepository
    {
        Role Create(Role role);
        Role Update(Role role);
        Role Get(int id);
        List<Role> GetAll();
        void Delete(Role role);
        IEnumerable<Role> GetSelectedRoles(IList<int> ids);
    }
}