using Microsoft.EntityFrameworkCore;
using SwiftEd.Context;
using SwiftEd.Interface.Repository;
using SwiftEd.Models;
using System.Collections.Generic;
using System.Linq;

namespace SwiftEd.Implementation.Repository
{
    public class AdminRepository : IAdminRepository
    {

        private readonly ApplicationContext _context;

        public AdminRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Admin Create(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
            return admin;
        }

        public void Delete(Admin admin)
        {
            _context.Admins.Remove(admin);
            _context.SaveChanges();
        }

        public Admin Get(int id)
        {
           return _context.Admins.Include(a => a.User).SingleOrDefault(a => a.Id == id);
         
        }

        public List<Admin> GetAll()
        {
            return _context.Admins.Include(a => a.User).ToList();
        }

        public IEnumerable<Admin> GetSelectedAdmins(IList<int> ids)
        {
            return _context.Admins.Where(a => ids.Contains(a.Id)).Include(a => a.User).ToList();   
        }

        public Admin Update(Admin admin)
        {
            _context.Admins.Update(admin);
            _context.SaveChanges();
            return admin;
        }
    }
}