using RMedia.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMedia.Service.Users
{
    public class UserService : IUser
    {
        public bool CreateUser(User user)
        {
            // This is where i would have a reference to database context and add the user to database.
            // Data would be created using code first approach 

            // Depending on what kind of user is being created whether a student of faculty that would be figured our bu the 
            // bool values in user object
            // I would add a record in student or faculty 
            return true;
        }
    }
}
