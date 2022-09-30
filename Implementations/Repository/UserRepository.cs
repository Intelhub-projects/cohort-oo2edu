using SwiftEd.Context;
using SwiftEd.Interface.Repository;
using SwiftEd.Models;
using System.Collections.Generic;
using System.Linq;

namespace SwiftEd.Implementation.Repository
{
    public class UserRepository : IUserRepository
    {
      private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public User Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void Delete(User role)
        {
            _context.Users.Remove(role);
            _context.SaveChanges();
        }

        public User Get(int id)
        {
           return _context.Users.Find(id);
         
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }


        public IEnumerable<User> GetSelectedUsers(IList<int> ids)
        {
            return _context.Users.Where(a => ids.Contains(a.Id)).ToList();
        }

        public User Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }  
    }
}