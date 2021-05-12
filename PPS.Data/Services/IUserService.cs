using System;
using System.Collections.Generic;

using PPS.Core.Models;

namespace PPS.Data.Services
{
    // This interface describes the operations that a StudentService class should implement
    public interface IUserService
    {
        // Initialise the repository - only to be used during development 
        void Initialise();

        // ---------------- User Management --------------
        IList<User> GetUsers();
        User GetUser(int id);
        User GetUserByEmail(string email, int? id);
        User AddUser(string name, string email, string password, Role role);
        User UpdateUser(User user);
        bool DeleteUser(int id);
        User Authenticate(string email, string password);
       
    }
    
}
