using RMedia.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMedia.Service.Users
{
    public interface IUser
    {
        public bool CreateUser(User user);
    }
}
