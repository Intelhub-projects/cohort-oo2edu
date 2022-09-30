using SwiftEd.Context;
using SwiftEd.Interface.Repository;
using SwiftEd.Models;
using System.Collections.Generic;
using System.Linq;

namespace SwiftEd.Implementation.Repository
{
    public class RoleRepository : IRoleRepository
    {
      private readonly ApplicationContext _context;

        public RoleRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Role Create(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role;
        }

        public void Delete(Role role)
        {
            _context.Roles.Remove(role);
            _context.SaveChanges();
        }

        public Role Get(int id)
        {
           return _context.Roles.Find(id);
         
        }

        public List<Role> GetAll()
        {
            return _context.Roles.ToList();
        }

        public IEnumerable<Role> GetSelectedRoles(IList<int> ids)
        {
            return _context.Roles.Where(a => ids.Contains(a.Id)).ToList();   
        }

        public Role Update(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
            return role;
        }  
    }
}