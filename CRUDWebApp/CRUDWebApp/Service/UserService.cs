using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDWebApp.Context;
using CRUDWebApp.IService;
using CRUDWebApp.Models;

namespace CRUDWebApp.Service
{
    public class UserService : IUserService
    {
        private readonly DatabaseContext _context;

        public UserService(DatabaseContext context)
        {
            _context = context;
        }
        public string Delete(int userId)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserId == userId);
            if (user == null) return "Deleted";
            _context.Users.Remove(user);
            _context.SaveChanges();
            return "Deleted";
        }

        public User GetUserById(int userId)
        {
            return _context.Users.SingleOrDefault(x => x.UserId == userId);
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public void Save(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
