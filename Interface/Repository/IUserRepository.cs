using SwiftEd.Models;
using System.Collections.Generic;

namespace SwiftEd.Interface.Repository
{
    public interface IUserRepository
    {
   
        User Create(User user);
        User Update(User user);
        User Get(int id);
        List<User> GetAll();
        void Delete(User user);
        IEnumerable<User> GetSelectedUsers(IList<int> ids);
    }    
    
}