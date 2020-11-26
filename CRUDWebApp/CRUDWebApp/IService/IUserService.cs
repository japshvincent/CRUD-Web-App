using System.Collections.Generic;
using CRUDWebApp.Models;

namespace CRUDWebApp.IService
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetUserById(int userId);
        void Save(User user);
        void Update(User user);
        string Delete(int userId);
    }
}
